import { environment } from 'src/environments/environment';

export class BaseService {

    constructor(
        private routeUrl: string,
    ) { }

    protected getRootUrl(): string {
        return environment.apiUrl + this.routeUrl;
    }

    protected getPageUrl(page: any): string {
        return this.getRootUrl() + '?page=' + page;
    }

    protected getOneUrl(id: any): string {
        return this.getRootUrl() + '/' + id;
    }

    protected getDropdownUrl(): string {
        return this.getRootUrl() + '/dropdown';
    }

}
