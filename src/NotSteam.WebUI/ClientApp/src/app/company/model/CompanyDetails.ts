import { BaseEntity } from 'src/app/shared/Model/base-entity';

export class CompanyDetails implements BaseEntity {
    id: number;
    name: string;
    description?: string;
    homepageUri?: string;
    logoImageUri?: string;
}
