import { BaseEntity } from 'src/app/shared/Model/base-entity';

export class User extends BaseEntity {
    username: string;
    password: string;
    nickname: string;
    email: string;
    dateOfBirth: string;
    profileImageUri: string;
}
