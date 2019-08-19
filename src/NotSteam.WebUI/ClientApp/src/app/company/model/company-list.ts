import { BaseEntity } from 'src/app/shared/Model/base-entity';

export interface CompanyList extends BaseEntity {
    name: string;
    description?: string;
}
