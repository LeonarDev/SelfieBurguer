# SelfieBurguer API

A SelfieBurguer API tem a finalidade de realizar o autoatendimento do cliente, para que possa realizar seus pedidos sem a necessidade de interação com um atendente.

Técnicamente, este projeto é impulsionado pelo Docker Compose, no qual constrói toda a estrutura responsável pela execução da aplicação localmente, iniciando com o banco de dados SQL Server, em seguida cria as tabelas e por fim constrói os projetos em .NET 6, seguindo uma abordagem de Domain Driven Design. 

A proposta é manter uma arquitetura limpa e escalável, que reflete constantemente as tendências atuais da Arquitetura de Software.

<br>

> 🚧 Projeto em construção, porém funcional. Confira aqui em baixo as formas de executá-lo.

<br>
<hr>
<br>

## 👨‍💻 Instruções de execução no terminal
Após clonar o projeto, acesse o diretório raiz e abra o terminal de sua preferência.

Execute o comando `./ambiente-iniciar.ps1` (Windows) ou `./ambiente-iniciar.sh` (Linux e Mac) para buildar a aplicação:

```sh
# Os arquivos de script "ambiente-iniciar.ps1" e "ambiente-iniciar.sh" executam:
docker-compose -f .\docker-compose.yml up
```

<div style="text-align:center;">
	<img src="./assets/1.png">
</div>

<br>
<br>

Abra seu navegador e acesse a documentação da aplicação pela url `http://localhost:8001/swagger`.

<div style="text-align:center;">
	<img src="./assets/2.png">
</div>

<br>
<br>

##### ⚠️ Para finalizar os containers, digite `CTRL+C` no terminal e em seguida execute o comando `./ambiente-parar.ps1` (Windows) ou `./ambiente-parar.sh` (Linux e Mac).

```sh
# Os arquivos de script "ambiente-parar.ps1" e "ambiente-parar.sh" executam:
docker-compose -f .\docker-compose.yml down ; docker rm $(docker ps -q --filter status=exited) ;  docker ps -a
```

<div style="text-align:center;">
	<img src="./assets/3.png">
</div>

<br>
<hr>
<br>

## 🆚 Instruções de execução no visual studio
No Gerenciador de Soluções, localize o arquivo `docker-compose`:
<div style="text-align:center;">
	<img src="./assets/4.png">
</div>

<br>
<br>


Clique com o botão direito em cima dele e marque a opção "Definir projeto de inicialização":
<div style="text-align:center;">
	<img src="./assets/5.png">
</div>

<br>
<br>

Em seguida, clique no ícone de "play" verde do Docker Compose, localizado no centro superior da IDE:
<div style="text-align:center;">
	<img src="./assets/6.png">
</div>

<br>
<br>

Aguarde alguns instantes até que o navegador abra automaticamente o swagger da aplicação.