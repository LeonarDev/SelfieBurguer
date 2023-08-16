#!/bin/bash
wait_time=10s

# wait for SQL Server to come up
echo ATENCAO! SCRIPTS SENDO EXECUTADOS EM $wait_time SEGUNDOS...
sleep $wait_time

# run scripts in /schemas folder to create the DB and tables
# for entry in "schemas/*.sql"
# do
#     echo EXECUTANDO $entry
#     # /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P $SA_PASSWORD -i $entry
#     /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P $SA_PASSWORD -Q "use master"
#     /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P $SA_PASSWORD -Q "create table teste(Id INT NOT NULL IDENTITY PRIMARY KEY, Nome varchar(255) NOT NULL)"
# done


# /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P $SA_PASSWORD -Q "use master"
# /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P $SA_PASSWORD -Q "create table teste(Id INT NOT NULL IDENTITY PRIMARY KEY, Nome varchar(255) NOT NULL)"



# run scripts to populate by Bulk insert all these test data
# /opt/mssql-tools/bin/bcp Cliente in "data/Cliente.csv" -S localhost -U sa -P $SA_PASSWORD -d $DATABASE_NAME -c -t ','
# /opt/mssql-tools/bin/bcp Categoria in "data/Categoria.csv" -S localhost -U sa -P $SA_PASSWORD -d $DATABASE_NAME -c -t ','
# /opt/mssql-tools/bin/bcp Produto in "data/Produto.csv" -S localhost -U sa -P $SA_PASSWORD -d $DATABASE_NAME -c -t ','
# /opt/mssql-tools/bin/bcp Pedido in "data/Pedido.csv" -S localhost -U sa -P $SA_PASSWORD -d $DATABASE_NAME -c -t ','

# /opt/mssql-tools/bin/sqlcmd -S sqlserver -U sa -P YourStrong@Passw0rd -d master -i /tmp/init.sql
echo EXECUTANDO SCRIPTS...

/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P YourStrong@Passw0rd -d master -i ./init.sql

echo SCRIPTS EXECUTADOS!