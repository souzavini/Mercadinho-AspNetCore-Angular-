import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';


import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { VendaComponent } from './Venda/Venda.component';
import { ProdutoComponent } from './Produto/Produto.component';
import { VendedorComponent } from './Vendedor/Vendedor.component';
import { CadastroProdutoComponent } from './cadastrarProduto/cadastroProduto.component';
import { ProdutoService } from './Service/produto.service';
import { CadastroService } from './Service/cadastro.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    VendaComponent,
    ProdutoComponent,
    VendedorComponent,
    CadastroProdutoComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'venda', component: VendaComponent },
      { path: 'produto', component: ProdutoComponent },
      { path: 'vendedor', component: VendedorComponent },
      { path: 'cadastro-produto', component: CadastroProdutoComponent },
    ])
  ],
  providers: [ProdutoService,CadastroService],
  bootstrap: [AppComponent]
})
export class AppModule { }
