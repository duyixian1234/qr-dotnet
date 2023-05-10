var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "QR Creator", Version = "v1" });
});
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "QR Creator v1"));

app.MapGet("/qr", (string content) =>
{
    var generator = new QRCoder.QRCodeGenerator();
    var qrCodeData = generator.CreateQrCode(content, QRCoder.QRCodeGenerator.ECCLevel.Q);
    var qrCode = new QRCoder.PngByteQRCode(qrCodeData);
    return Results.File(qrCode.GetGraphic(20), "image/png");
});

app.Run("http://localhost:5000");
