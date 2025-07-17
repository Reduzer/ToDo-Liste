using Grpc.Net.Client;
using DatabaseService;

using var channel = GrpcChannel.ForAddress("https://localhost:8080");

var client = new UserS
