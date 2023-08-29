wait_time=10s

echo  
echo !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
echo !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
echo  
echo  
echo ATENCAO! SCRIPTS SENDO EXECUTADOS EM $wait_time...
echo  
echo  
echo !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
echo !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
echo  
sleep $wait_time

# run scripts in /schemas folder to create the DB and tables
# for entry in "schemas/*.sql"
# do
#     echo EXECUTANDO $entry
#     # /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P $SA_PASSWORD -i $entry
#     /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P $SA_PASSWORD -Q "use master"
#     /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P $SA_PASSWORD -Q "create table teste(Id INT NOT NULL IDENTITY PRIMARY KEY, Nome varchar(255) NOT NULL)"
# done

echo EXECUTANDO SCRIPTS...

/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P YourStrong@Passw0rd -d master -i ./init.sql

echo  
echo !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
echo !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
echo  
echo  
echo SCRIPTS EXECUTADOS!
echo  
echo  
echo !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
echo !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
echo  