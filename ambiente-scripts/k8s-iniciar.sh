echo 
echo .
echo ..
echo ...
echo ...CRIANDO DEPLOYMENT DO BANCO:
kubectl apply -f k8s/mssql-deployment.yaml;
echo ...
echo ..
echo .
echo 

sleep 3;

echo .
echo ..
echo ...
echo ...CRIANDO SERVICE DO BANCO:
kubectl apply -f k8s/mssql-service.yaml;
echo ...
echo ..
echo .
echo 

sleep 3;

echo .
echo ..
echo ...
echo ...CRIANDO DEPLOYMENT DA APLICACAO:
kubectl apply -f k8s/app-deployment.yaml;
echo ...
echo ..
echo .
echo 

sleep 3;

echo .
echo ..
echo ...
echo ...CRIANDO SERVICE DA APLICACAO:
kubectl apply -f k8s/app-service.yaml
echo ...
echo ..
echo .
echo 