# QR Dotnet

QR Dotnet is a minimal API web service that generates QR codes in PNG format for a given content. It is built with .NET 7.0 and uses the QRCoder library for QR code generation.

## Prerequisites

- .NET 7.0 SDK
- QRCoder library (installed via NuGet)

## Installation

1. Clone the repository: `git clone https://github.com/duyixian1234/qr-dotnet.git`
2. Navigate to the project directory: `cd qr-dotnet`
3. Build the project: `dotnet build`
4. Run the project: `dotnet run`
5. Open your web browser and go to `http://localhost:5000/swagger/index.html` to access the Swagger UI and test the API.

## Usage

Once the project is running, you can generate a QR code by sending a GET request to the `/qr` endpoint with the `content` parameter:

```
GET http://localhost:5000/qr?content=Hello%20world
```

This will generate a QR code with the specified content and return it in PNG format as a file.

## License

This project is licensed under the MIT License. See the `LICENSE` file for details
