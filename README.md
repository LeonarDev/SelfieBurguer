# SelfieBurguer API

A SelfieBurguer API é uma aplicação elaborada para o cliente realizar o autoatendimento do seu pedido sem a necessidade de interação com um atendente real.

## Stack

Técnicamente, este projeto é impulsionado pelo Docker Compose, no qual constrói a estrutura responsável pela execução da aplicação localmente com os containers:
- SQL Server
- Carga de dados para a construção do banco
- Web-Api em .NET 6 implementada com arquitetura hexagonal e Domain Driven Design

A proposta de desenvolvimento foi de manter uma arquitetura enxuta e escalável, refletindo constantemente as tendências mais modernas no contexto da Arquitetura de Software.

<br>

#### 🚧 Projeto em construção, porém funcional. Confira nas opções a baixo as formas de executá-lo:

<details>
<summary>Executar via Kubernets</summary>

# 🚧

<br>

</details>


<details>
<summary>Executar via Docker-Compose</summary>

## 👨‍💻 Instruções de execução no terminal
Abra o terminal de sua preferência, clone o projeto e acesse o diretório raiz.

Execute o comando `./ambiente-iniciar.ps1` (Windows com WSL2) ou `./ambiente-iniciar.sh` (Linux e Mac) para buildar a aplicação:

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

⚠️ Para finalizar os containers, digite `CTRL+C` no terminal e em seguida execute o comando `./ambiente-parar.ps1` (Windows com WSL2) ou `./ambiente-parar.sh` (Linux e Mac).

```sh
# Os arquivos de script "ambiente-parar.ps1" e "ambiente-parar.sh" executam:
docker-compose -f .\docker-compose.yml down ; docker rm $(docker ps -q --filter status=exited) ;  docker ps -a
```

<div style="text-align:center;">
	<img src="./assets/3.png">
</div>
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

</details>