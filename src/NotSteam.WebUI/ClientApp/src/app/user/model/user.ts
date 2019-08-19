import { BaseEntity } from 'src/app/shared/Model/base-entity';

export interface User extends BaseEntity {
    username: string;
    password: string;
    email: string;
    dateOfBirth: string;
    nickname?: string;
    profileImageUri?: string;
}
