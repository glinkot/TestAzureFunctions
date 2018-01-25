public static void Run(Stream myBlob, string name, TraceWriter log)
{
    log.Info($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
    log.Info("blah!");

    // convert stream to string
    StreamReader reader = new StreamReader( myBlob );
    string text = reader.ReadToEnd();

    log.Info(text);
}
