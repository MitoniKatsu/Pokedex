import { Component, OnInit, OnDestroy } from '@angular/core';
import { PokemonService } from 'src/app/services/pokemon.service';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';
import { SimpleSpecies } from 'src/app/models/pokemon-species';
import { MatDialogRef } from '@angular/material/dialog';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { CreatePokemon } from 'src/app/models/pokemon';

@Component({
  selector: 'app-add-pokemon-dialog',
  templateUrl: './add-pokemon-dialog.component.html',
  styleUrls: ['./add-pokemon-dialog.component.css']
})
export class AddPokemonDialogComponent implements OnInit, OnDestroy {

  constructor(private dialogRef: MatDialogRef<AddPokemonDialogComponent>, private pokemonService: PokemonService) { }

  speciesList: SimpleSpecies[];
  unSubscribe: Subject<any> = new Subject();
  pokemonName: string;
  pokemonSpecies: number;

  addPokemonForm: FormGroup;

  ngOnInit() {
    this.addPokemonForm = new FormGroup ({
      'pokemonName': new FormControl('', [Validators.required, Validators.minLength(1)]),
      'pokemonSpecies': new FormControl('', Validators.required)
    });
    this.getSpeciesList();
  }

  ngOnDestroy() {
    this.unSubscribe.next();
    this.unSubscribe.complete();
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
    const newPokemon: CreatePokemon = {
      pokemonName: this.addPokemonForm.get('pokemonName').value,
      speciesID: this.addPokemonForm.get('pokemonSpecies').value
    };
    this.dialogRef.close(newPokemon);

  }

  close() {
    this.dialogRef.close();
  }
}
