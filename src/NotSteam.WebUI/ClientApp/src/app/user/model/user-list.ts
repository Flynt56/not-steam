import { BaseEntity } from 'src/app/shared/Model/base-entity';

export class UserList extends BaseEntity {
    name: string;
    nick: string;
    email: string;
    dob: string;
}
