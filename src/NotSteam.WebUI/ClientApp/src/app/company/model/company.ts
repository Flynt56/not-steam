import { BaseEntity } from 'src/app/shared/Model/base-entity';

export interface Company extends BaseEntity {
    name: string;
    description?: string;
    homepageUri?: string;
    logoImageUri?: string;
}
