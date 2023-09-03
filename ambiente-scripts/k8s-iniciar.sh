kubectl apply -f k8s/mssql-deployment.yaml;
sleep 2;
kubectl apply -f k8s/mssql-service.yaml;
sleep 2;
kubectl apply -f k8s/app-deployment.yaml;
sleep 2;
kubectl apply -f k8s/app-service.yaml