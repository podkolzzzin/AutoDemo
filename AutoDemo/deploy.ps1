dotnet publish -o output
scp -i private.key -r output root@auto.lastseendemo.top:/server
ssh -i private.key root@auto.lastseendemo.top 'sudo kill -9 `sudo lsof -t -i:80`'
ssh -i private.key root@auto.lastseendemo.top 'cd /server/output && dotnet AutoDemo.dll --urls="http://[::]/"'