using Docker.DotNet;
using Docker.DotNet.Models;

Console.WriteLine("Starting dirman...");

var dockerClient = new DockerClientConfiguration().CreateClient();

try
{
    await dockerClient.Containers.ListContainersAsync(new ContainersListParameters());
}
catch (Exception)
{
    Console.WriteLine("Dirman failed: Docker didn't dockerz. Start it you n00b.");
    return;
}

Console.WriteLine("Listing running containers");
var containers = await dockerClient.Containers.ListContainersAsync(new ContainersListParameters());
foreach (var container in containers)
{
    Console.WriteLine("ID: " + container.ID);
    Console.WriteLine("State: "+ container.State);
    Console.WriteLine("Image: " + container.Image);
    Console.WriteLine("ImageID:" + container.ImageID);
}

Console.WriteLine("Listing images...");
var images = await dockerClient.Images.ListImagesAsync(new ImagesListParameters());
foreach (var image in images)
{
    Console.WriteLine("ID: " + image.ID);
    Console.WriteLine("Size: " + image.Size);
}

Console.WriteLine("Stopping dirman...");