import { Injectable} from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Produto } from '../modelo/produto';

@Injectable({
    providedIn: 'root'
})

export class ProdutoService{

    constructor(private http: HttpClient){
    
    }

    baseUrl = `${environment.UrlPrincipal}/api/produto}`;
    getAll(): Observable<Produto[]>{
        return this.http.get<Produto[]>("https://localhost:44333/api/produto");
    }
}