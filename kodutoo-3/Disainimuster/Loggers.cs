
BaseLogger[] loggerid =
{
    new NullLoggerAdapter(),
    new ConsoleLogger(),
    new DebugLogger()
};

foreach (BaseLogger logger in loggerid)
{
    
    Console.WriteLine(logger.ToString());

    logger.Info("Programm käivitati");
    logger.Debug("debug teade");
    logger.Warning("hoiatusteade");
    logger.Error("veateade");
}

// baselogger
public abstract class BaseLogger
{
    public abstract void Info(string message);

    public abstract void Error(string message);

    public abstract void Debug(string message);

    public abstract void Warning(string message);
}

// Debug logger
public class DebugLogger : BaseLogger
{
    public override void Info(string message)
    {
        System.Diagnostics.Debug.WriteLine("INFO: " + message);
    }

    public override void Error(string message)
    {
        System.Diagnostics.Debug.WriteLine("ERROR: " + message);
    }

    public override void Debug(string message)
    {
        System.Diagnostics.Debug.WriteLine("DEBUG: " + message);
    }

    public override void Warning(string message)
    {
        System.Diagnostics.Debug.WriteLine("WARNING: " + message);
    }
}

// Console logger
public class ConsoleLogger : BaseLogger
{
    public override void Info(string message)
    {
        Console.WriteLine("INFO: " + message);
    }

    public override void Error(string message)
    {
        Console.WriteLine("ERROR: " + message);
    }

    public override void Debug(string message)
    {
        Console.WriteLine("DEBUG: " + message);
    }

    public override void Warning(string message)
    {
        Console.WriteLine("WARNING: " + message);
    }
}

// NullLogger
public class NullLogger
{
    public void WriteDebug(string message) { }
    public void WriteInfo(string message) { }
    public void WriteWarning(string message) { }
    public void WriteError(string message) { }
}

// adapter disainimuster

public class NullLoggerAdapter : BaseLogger
{
    
    private NullLogger nullLogger = new NullLogger();

    public override void Info(string message)
    {
        nullLogger.WriteInfo(message);
    }

    public override void Debug(string message)
    {
        nullLogger.WriteDebug(message);
    }

    public override void Warning(string message)
    {
        nullLogger.WriteWarning(message);
    }

    public override void Error(string message)
    {
        nullLogger.WriteError(message);
    }
}