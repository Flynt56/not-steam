import { GameDetails } from './GameDetails';
import { CompanyDropdown } from 'src/app/company/model/CompanyDropdown';

export class GameEditForm {
    game: GameDetails;
    companies: Array<CompanyDropdown>;
}
