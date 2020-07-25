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

    baseUrl = `${environment.UrlPrincipal}/api/produto`;
    getAll(): Observable<Produto[]>{
        return this.http.get<Produto[]>(`${this.baseUrl}`);
    }

    getById(id:number): Observable<Produto>{
        return this.http.get<Produto>(`${this.baseUrl}/${id}`);
    }

    post(produto: Produto){
        return this.http.post(`${this.baseUrl}`,produto);
    }

    put(id:number, produto: Produto){
        return this.http.put(`${this.baseUrl}/${id}`,produto);
    }

    delete(id: number){
        return this.http.delete(`${this.baseUrl}/${id}`);
    }

}