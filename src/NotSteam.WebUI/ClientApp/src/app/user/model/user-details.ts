import { BaseEntity } from 'src/app/shared/Model/base-entity';

export class UserDetails extends BaseEntity {
    name: string;
    nick: string;
    dob: string;
    password: string;
    email: string;
    profileImageUri: string;
}
