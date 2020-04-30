import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Pokemon, CreatePokemon, UpdatePokemon } from '../models/pokemon';
import { Observable } from 'rxjs';
import { PokemonSpecies, SimpleSpecies } from '../models/pokemon-species';

@Injectable({
  providedIn: 'root'
})
export class PokemonService {

  constructor(@Inject('API_BASE_URL') private baseApiUrl: string, private http: HttpClient) { }

  GetAllPokemon(): Observable<HttpResponse<Pokemon[]>> {
    return this.http.get<Pokemon[]>(this.baseApiUrl + 'pokemon', {
      observe: 'response'});
  }

  GetPokemon(pokemonID: number): Observable<HttpResponse<Pokemon[]>> {
    return this.http.get<Pokemon[]>(this.baseApiUrl + `pokemon/${pokemonID}`, {
      observe: 'response'});
  }

  AddPokemon(newPokemon: CreatePokemon): Observable<HttpResponse<string>> {
    return this.http.post<string>(this.baseApiUrl + 'pokemon', newPokemon, {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'}),
        observe: 'response'});
  }

  UpdatePokemon(updatedPokemon: UpdatePokemon): Observable<HttpResponse<string>> {
    return this.http.put<string>(this.baseApiUrl + 'pokemon', updatedPokemon, {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'}),
        observe: 'response'});
  }

  DeletePokemon(pokemonID: number): Observable<HttpResponse<string>> {
    return this.http.delete<string>(this.baseApiUrl + `pokemon/${pokemonID}`, {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'}),
        observe: 'response'});
  }

  GetSpeciesList(): Observable<HttpResponse<SimpleSpecies[]>> {
    return this.http.get<SimpleSpecies[]>(this.baseApiUrl + 'species', {
      observe: 'response'
    });
  }
}
