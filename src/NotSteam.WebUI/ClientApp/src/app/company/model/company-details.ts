import { BaseEntity } from 'src/app/shared/Model/base-entity';

export interface CompanyDetails extends BaseEntity {
    name: string;
    description?: string;
    homepageUri?: string;
    logoImageUri?: string;
}
