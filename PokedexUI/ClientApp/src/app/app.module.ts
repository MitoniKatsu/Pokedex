import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { MaterialModule } from './material';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AddPokemonDialogComponent } from './dashboard/add-pokemon-dialog/add-pokemon-dialog.component';
import { UpdatePokemonDialogComponent } from './dashboard/update-pokemon-dialog/update-pokemon-dialog.component';

@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    AddPokemonDialogComponent,
    UpdatePokemonDialogComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    MaterialModule,
    BrowserAnimationsModule
  ],
  providers: [
    { provide: 'API_BASE_URL', useValue: 'https://cen4333.azurewebsites.net/Pokedex/'}
    //{ provide: 'API_BASE_URL', useValue: 'https://localhost:44317/Pokedex/'}
  ],
  entryComponents: [
    AddPokemonDialogComponent,
    UpdatePokemonDialogComponent
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
