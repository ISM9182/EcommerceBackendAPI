# EcommerceBackendAPI

Este é o backend da aplicação de e-commerce, desenvolvido em C# com .NET 8, que fornece uma API RESTful para gerenciar produtos. Ele se integra com o frontend `Ecommerce-RetroDrive` (do trabalho 2) para oferecer uma experiência completa de e-commerce.

## Funcionalidades

Este web service oferece as seguintes operações CRUD (Create, Read, Update, Delete) para a entidade `Product` (Produto):

* **`GET /api/Products`**: Lista todos os produtos.
* **`GET /api/Products/{id}`**: Retorna um produto específico pelo seu ID.
* **`POST /api/Products`**: Cria um novo produto.
* **`PUT /api/Products/{id}`**: Atualiza um produto existente.
* **`DELETE /api/Products/{id}`**: Exclui um produto.

Os dados são persistidos em um banco de dados **In-Memory** do .NET.

## Princípios SOLID

O projeto foi desenvolvido seguindo os princípios SOLID de programação orientada a objetos para garantir uma arquitetura modular, extensível e de fácil manutenção. 

## Como Rodar a Aplicação

A aplicação pode ser compilada e executada utilizando Docker.

### Pré-requisitos

* [Docker Desktop](https://www.docker.com/products/docker-desktop/) instalado e em execução.

### Passos para Rodar com Docker

1.  **Clone este repositório:**
    ```bash
    git clone https://github.com/ISM9182/EcommerceBackendAPI.git
    cd EcommerceBackendAPI
    ```

2.  **Construa a imagem Docker:**
    ```bash
    docker build -t ecommerce-api .
    ```
    *Se você tiver problemas de cache, pode tentar:*
    ```bash
    docker build -t ecommerce-api --no-cache .
    ```

3.  **Execute o contêiner Docker:**
    ```bash
    docker run -d -p 5037:8080 --name ecommerce-api-container ecommerce-api
    ```
    * A API estará disponível em `http://localhost:5037`.

4.  **Verifique se o contêiner está rodando:**
    ```bash
    docker ps
    ```
    (Print da saída do `docker ps` mostrando o contêiner `ecommerce-api-container` como 'Up')
    {


PS C:\Users\Ismael\EcommerceBackendAPI> docker ps
CONTAINER ID   IMAGE           COMMAND                  CREATED          STATUS          
PORTS                                         NAMES
f49ac5e19720   ecommerce-api   "dotnet EcommerceBac…"   43 minutes ago   Up 43 minutes   0.0.0.0:5037->8080/tcp, [::]:5037->8080/tcp   ecommerce-api-container


    }

## Evidências de Funcionamento (Prints de Tela)

Aqui estão as evidências do funcionamento da API, testada via Postman, rodando dentro do contêiner Docker.

### 1. Criar Produto (POST /api/Products)

(IMAGEM DO POSTMAN/INSOMNIA MOSTRANDO A REQUISIÇÃO POST COM STATUS 201 E O CORPO DA RESPOSTA)
![Print da Requisição POST](Meu Drive/WEB/imagem03.png)

### 2. Listar Todos os Produtos (GET /api/Products)

(IMAGEM DO POSTMAN/INSOMNIA MOSTRANDO A REQUISIÇÃO GET ALL COM STATUS 200 E O CORPO DA RESPOSTA)
<img width="827" height="597" alt="Captura de tela 2025-08-03 182340" src="https://github.com/user-attachments/assets/2318c512-ac34-47d1-8f00-70e1b7648004" />

### 3. Buscar Produto por ID (GET /api/Products/{id})

(IMAGEM DO POSTMAN/INSOMNIA MOSTRANDO A REQUISIÇÃO GET BY ID COM STATUS 200 E O CORPO DA RESPOSTA)
![Print da Requisição GET By ID](caminho/para/sua/imagem-get-by-id.png)

### 4. Atualizar Produto (PUT /api/Products/{id})

(IMAGEM DO POSTMAN/INSOMNIA MOSTRANDO A REQUISIÇÃO PUT COM STATUS 204)
![Print da Requisição PUT](caminho/para/sua/imagem-put.png)

### 5. Deletar Produto (DELETE /api/Products/{id})

(IMAGEM DO POSTMAN/INSOMNIA MOSTRANDO A REQUISIÇÃO DELETE COM STATUS 204)
![Print da Requisição DELETE](caminho/para/sua/imagem-delete.png)

---

**Para incluir as imagens no `README.md`:**

1.  Salve seus prints de tela em uma pasta dentro do seu repositório (ex: `docs/images/`).
2.  No `README.md`, use a sintaxe `![Descrição da Imagem](caminho/para/sua/imagem.png)`.

---

### **3. Integração com o `Ecommerce-RetroDrive` (Trabalho 2)**

A integração com seu frontend (o `Ecommerce-RetroDrive` do trabalho 2) acontece **alterando a URL da API no seu código frontend**.

No seu projeto React do `Ecommerce-RetroDrive` (ou seja, o frontend), você deve ter um lugar onde a URL base da API é configurada. Provavelmente, é algo como `http://localhost:XXXX/api/...`.

**Você precisará mudar essa URL para apontar para o seu backend Dockerizado:**

* **Altere a URL da API no seu frontend React para `http://localhost:5037`**.
    * Se, por exemplo, seu frontend estava fazendo requisições para `http://localhost:5000/api/products`, agora ele deve fazer para `http://localhost:5037/api/products`.

Depois de mudar a URL no seu frontend React, você precisará:

1.  Salvar as alterações no seu projeto `Ecommerce-RetroDrive`.
2.  Iniciar o seu frontend React (geralmente com `npm start` ou `yarn start`).
3.  Com o backend Dockerizado rodando (`docker ps` mostrando `Up`) e o frontend React iniciado, você poderá navegar no seu site `Ecommerce-RetroDrive` e as operações de adicionar, ver, editar e deletar produtos (ou a entidade que você escolheu) deverão funcionar através do backend rodando no Docker.

Seu professor provavelmente testará isso acessando seu frontend e vendo as operações funcionarem.

---

**Em resumo, o que você precisa fazer agora é:**

1.  Criar/Editar o `README.md` na pasta raiz do seu backend.
2.  Inserir os prints de tela de todos os testes CRUD bem-sucedidos no `README.md`.
3.  Seu código C# (SOLID) já parece OK, mas você pode revisá-lo.
4.  Certificar-se de que o repositório GitHub para este backend está atualizado com tudo isso.
5.  **Mudar a URL da API no seu projeto React (`Ecommerce-RetroDrive`) para `http://localhost:5037`** e testar a integração.

Me avise se tiver qualquer dúvida sobre esses passos! Você está quase lá!
