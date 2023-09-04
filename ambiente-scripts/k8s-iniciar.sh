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


echo .
echo ..
echo ...
echo ...CRIANDO SERVICE DO BANCO:
sleep 3;
kubectl apply -f k8s/mssql-service.yaml;
echo ...
echo ..
echo .
echo 


echo .
echo ..
echo ...
echo ...CRIANDO DEPLOYMENT DA APLICACAO:
sleep 3;
kubectl apply -f k8s/app-deployment.yaml;
echo ...
echo ..
echo .
echo 


echo .
echo ..
echo ...
echo ...CRIANDO SERVICE DA APLICACAO:
sleep 3;
kubectl apply -f k8s/app-service.yaml
echo ...
echo ..
echo .
echo 