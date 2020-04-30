import { Component, OnInit, OnDestroy, Inject } from '@angular/core';
import { PokemonService } from 'src/app/services/pokemon.service';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';
import { SimpleSpecies } from 'src/app/models/pokemon-species';
import { MatDialogRef, MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { CreatePokemon, UpdatePokemon, Pokemon } from 'src/app/models/pokemon';

@Component({
  selector: 'app-update-pokemon-dialog',
  templateUrl: './update-pokemon-dialog.component.html',
  styleUrls: ['./update-pokemon-dialog.component.css']
})
export class UpdatePokemonDialogComponent implements OnInit, OnDestroy {

  constructor(@Inject(MAT_DIALOG_DATA) private data: any,
    private dialogRef: MatDialogRef<UpdatePokemonDialogComponent>,
    private pokemonService: PokemonService) {
      if (data !== null) {
        this.pokemonToUpdate = data;
      }
    }

  speciesList: SimpleSpecies[];
  unSubscribe: Subject<any> = new Subject();

  pokemonToUpdate: Pokemon;

  updatePokemonForm: FormGroup;

  ngOnInit() {
    this.updatePokemonForm = new FormGroup ({
      'pokemonName': new FormControl('', [Validators.required, Validators.minLength(1)]),
      'pokemonSpecies': new FormControl('', Validators.required)
    });
    this.getSpeciesList();
    this.setForm();
  }

  ngOnDestroy() {
    this.unSubscribe.next();
    this.unSubscribe.complete();
  }

  setForm() {
    this.updatePokemonForm.setValue({
      pokemonName: this.pokemonToUpdate.pokemonName,
      pokemonSpecies: this.pokemonToUpdate.pokemonSpecies.speciesID
    });
  }

  getSpeciesList() {
    this.pokemonService.GetSpeciesList()
      .pipe(takeUntil(this.unSubscribe))
      .subscribe(res => {
        if (res.body !== null) {
          this.speciesList = res.body;
        }
      }, error => {
        console.log(error);
        this.dialogRef.close();
      });
  }

  submit() {
    const updatedPokemon: UpdatePokemon = {
      pokemonID: this.pokemonToUpdate.pokemonID,
      pokemonName: this.updatePokemonForm.get('pokemonName').value,
      speciesID: this.updatePokemonForm.get('pokemonSpecies').value
    };

    this.dialogRef.close(updatedPokemon);

  }

  close() {
    this.dialogRef.close();
  }
}
