import { PokemonSpecies } from './pokemon-species';

export class Pokemon {
  pokemonID: number;
  pokemonName: string;
  pokemonSpecies: PokemonSpecies;
}

export class CreatePokemon {
  pokemonName: string;
  speciesID: number;
}

export class UpdatePokemon {
  pokemonID: number;
  pokemonName: string;
  speciesID: number;
}
