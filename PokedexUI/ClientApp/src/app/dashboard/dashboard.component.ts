import { Component, OnInit, OnDestroy } from '@angular/core';
import { Pokemon, CreatePokemon, UpdatePokemon } from '../models/pokemon';
import { PokemonService } from '../services/pokemon.service';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatDialogConfig, MatDialog } from '@angular/material/dialog';
import { AddPokemonDialogComponent } from './add-pokemon-dialog/add-pokemon-dialog.component';
import { UpdatePokemonDialogComponent } from './update-pokemon-dialog/update-pokemon-dialog.component';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit, OnDestroy {

  constructor(private pokemonService: PokemonService, private snackBar: MatSnackBar, private dialog: MatDialog) { }
  unSubscribe: Subject<any> = new Subject();
  pokemon: Pokemon[] = [];
  loadingDone = false;
  ngOnInit() {
    this.loadPokemon();
  }

  ngOnDestroy() {
    this.unSubscribe.next();
    this.unSubscribe.complete();
  }

  loadPokemon() {
    this.pokemonService.GetAllPokemon()
      .pipe(takeUntil(this.unSubscribe))
      .subscribe(
        res => {
          if (res.status === 200) {
            this.pokemon = res.body;
          }
          console.log(res.body);
          this.loadingDone = true;
        },
        error => {
          if (error) {
            this.openSnackbar('Error occured during request', 'error');
            console.log('error', error);
          }
        }
      );
  }

  addPokemon(newPokemon: CreatePokemon) {
    this.pokemonService.AddPokemon(newPokemon)
      .pipe(takeUntil(this.unSubscribe))
      .subscribe(
        res => {
          if (res.status === 201) {
            this.openSnackbar('Pokemon Added', null);
            this.loadPokemon();
          }
        },
        error => {
          if (error) {
            this.openSnackbar('Error occured during request', 'error');
            console.log('error', error);
          }
        });
  }

  updatePokemon(updatedPokemon: UpdatePokemon) {
    this.pokemonService.UpdatePokemon(updatedPokemon)
      .pipe(takeUntil(this.unSubscribe))
      .subscribe(
        res => {
          if (res.status === 200) {
            this.openSnackbar('Pokemon Updated', null);
            this.loadPokemon();
          }
        },
        error => {
          if (error) {
            this.openSnackbar('Error occured during request', 'error');
            console.log('error', error);
          }
        });
  }

  deletePokemon(pokemon: Pokemon) {
    this.pokemonService.DeletePokemon(pokemon.pokemonID)
      .pipe(takeUntil(this.unSubscribe))
      .subscribe(
        res => {
          if (res.status === 200) {
            this.openSnackbar(`${pokemon.pokemonName} Deleted`, null);
            this.loadPokemon();
          }
        },
        error => {
          if (error) {
            this.openSnackbar('Error occured during request', 'error');
            console.log('error', error);
          }
        });
  }

  openSnackbar(message: string, action: string, duration: number = 3000) {
    if (action === 'Error') {
      this.snackBar.open(message, action, {
        duration: 3000,
        panelClass: ['error-snackbar']
      });
    }
    this.snackBar.open(message, action, {
      duration: duration,
      panelClass: ['success-snackbar']
    });
  }

  openAddPokemonDialog() {
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = false;
    const dialogRef = this.dialog.open(AddPokemonDialogComponent, dialogConfig);
    dialogRef.afterClosed()
    .pipe(takeUntil(this.unSubscribe))
    .subscribe(result => {
      if (result !== undefined && result !== null) {
        this.addPokemon(result);
      }
    });
  }

  openUpdatePokemonDialog(pokemonToUpdate: Pokemon) {
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = false;
    dialogConfig.data = pokemonToUpdate;
    const dialogRef = this.dialog.open(UpdatePokemonDialogComponent, dialogConfig);
    dialogRef.afterClosed()
    .pipe(takeUntil(this.unSubscribe))
    .subscribe(result => {
      if (result !== undefined && result !== null) {
        this.updatePokemon(result);
      }
    });
  }
}
