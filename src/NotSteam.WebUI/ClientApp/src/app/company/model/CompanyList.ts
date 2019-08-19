import { BaseEntity } from 'src/app/shared/Model/base-entity';

export class CompanyList implements BaseEntity {
    id: number;
    name: string;
    description?: string;
}
