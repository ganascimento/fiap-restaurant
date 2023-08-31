# FIAP-RESTAURANT

## Inicializando o projeto

### Docker

Inicie os containers acessando a raiz do projeto, e rodando o comando:

```PowerShell
docker compose up -d --build
```

### Kubernets

Inicie os pods acessando a raiz do projeto, e rodando o comando:

```PowerShell
kubectl apply -f .\kubernets\
```

### Utilização dos endpoints

Os endpoints disponíveis podem ser acessados via [swager](http://localhost:5001/swagger/index.html)

Também temos uma [collection do Postman](/postman/fiap-restaurant.postman_collection.json)

kubectl apply -f kubernets/pv.yml;
kubectl apply -f kubernets/pvc.yml;
kubectl apply -f kubernets/mysql-configmap.yml;
kubectl apply -f kubernets/mysql-deployment.yml;
kubectl apply -f kubernets/mysql-svs.yml;
