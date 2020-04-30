import { PokemonType } from './pokemon-type';

export class PokemonSpecies {
  speciesID: number;
  speciesName: string;
  description: string;
  primaryType: PokemonType;
  secondaryType: PokemonType;
}

export class SimpleSpecies {
  speciesID: number;
  speciesName: string;
}
