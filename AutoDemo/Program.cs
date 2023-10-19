// See https://aka.ms/new-console-template for more information

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/version", () => new { version = 2 });

app.Run();

// 1. Rent the VM
// 2. Rent an Domain
// 3. Bind the VM ip to the Domain
// 4. Install dotnet or python on VM 
//        (you will need ssh root@VM_IP)
//        create folder for application (mkdir /server)
// 5. Create empty project
// 6. Launch and check it locally with 1 simple endpoint
// 7. Build an application (if dotnet)
//      dotnet publish -c Release -o output
// 8. Copy the output to the VM
//    scp -r output $SSH_USERNAME@$VM_IP:/server/
// 9. Start the application on the VM
//     dotnet <YOUR_APP>.dll --urls=http://[::]/

// scp -o StrictHostKeyChecking=no -i deploy_key -r .out $SSH_USERNAME@$VM_IP:/server/LastSeenDemo/.out
