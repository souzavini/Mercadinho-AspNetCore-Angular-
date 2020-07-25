import {Component, OnInit } from '@angular/core';
import { Produto } from '../modelo/produto';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ProdutoService } from '../Service/produto.service';

@Component({
    selector:'app-produto',
    templateUrl: './Produto.component.html',
    styleUrls: ['./Produto.component.css']
})

export class ProdutoComponent implements OnInit{
    public produtoForm: FormGroup;
    titulo = 'Produtos';
    public produtoSelecionado: Produto;

    public produtos: Produto[];

    constructor(private fb: FormBuilder,private produtoService: ProdutoService){
        this.criarForm();
     }

    ngOnInit(){
        var produtos = this.carregarProduto();
        console.log(produtos);
    }

    carregarProduto(){
        this.produtoService.getAll().subscribe(
            (produto: Produto[]) => { 
                this.produtos = produto;
            },
            (erro: any) =>{
                console.error(erro);
             }
        )
    }

    criarForm(){
        this.produtoForm = this.fb.group({
            idProduto:[''],
            quantidade:['',Validators.required],
            precoUnitario:['',Validators.required],
            nomeProduto:['',Validators.required]
        });
    }
    salvarProduto(produto: Produto){
        this.produtoService.put(produto.idProduto,produto).subscribe(
            (retorno: Produto)=> {
                console.log(retorno)
                this.carregarProduto();
            },
            (erro: any)=> {
                console.log(erro);
            }
        );
    }
    
    produtoSubmit(){
        this.salvarProduto(this.produtoForm.value);
        //console.log(this.produtoForm.value);
    }
    produtoSelect(produto: Produto){
        this.produtoSelecionado = produto;
        this.produtoForm.patchValue(produto);
    }
    voltar(){
        this.produtoSelecionado = null;
    }

    
}