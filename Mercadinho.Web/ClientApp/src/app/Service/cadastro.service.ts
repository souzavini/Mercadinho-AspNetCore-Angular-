import { Injectable} from '@angular/core';
import { HttpClient,HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Produto } from '../modelo/produto';

@Injectable({
    providedIn: 'root'
})

export class CadastroService{

    constructor(private http: HttpClient){
    
    }

    baseUrl = `${environment.UrlPrincipal}/api/produto`;

    post(produto: Produto): Observable<Produto>{
        const headers = new HttpHeaders().set('content-type', 'application/json');
        
        var body ={
            nomeProduto: produto.nomeProduto,
            precoUnitario: produto.precoUnitario,
            quantidade:produto.quantidade
        }
    
        return this.http.post<Produto>(`${this.baseUrl}`,JSON.stringify(body),{headers});
    }

}