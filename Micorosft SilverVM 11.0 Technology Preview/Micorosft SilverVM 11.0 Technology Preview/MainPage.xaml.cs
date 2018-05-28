        /// <summary> 

/// For more information about writing UDOs, please refer to http://go.microsoft.com/fwlink/?LinkID=623598&clcid=0x409 
/// </summary> 
[SqlUserDefinedExtractor]
public class NBFFSOC : IExtractor
{
    /// <summary> 
    ///  
    /// </summary> 
    /// <param name="input"></param> 
    /// <param name="outputrow"></param> 
    /// <returns></returns> 
    public override IEnumerable<IRow> Extract(IUnstructuredReader input, IUpdatableRow outputrow)
    {
        char column_delimiter = '\t';
        string line;
        var reader = new StreamReader(input.BaseStream);
        while ((line = reader.ReadLine()) != null)
        {
            var tokens = line.Split(column_delimiter);
            outputrow.Set("Name", tokens[0]);
            outputrow.Set("Company", tokens[1]);
            outputrow.Set("Salary", Convert.ToInt64(tokens[2]));
            yield return outputrow.AsReadOnly();
        }
    }
}

/// <summary> 

/// For more information about writing UDOs, please refer to http://go.microsoft.com/fwlink/?LinkID=623598&clcid=0x409 
/// </summary> 
[SqlUserDefinedExtractor]
public class NBFFSOC : IExtractor
{
    /// <summary> 
    ///  
    /// </summary> 
    /// <param name="input"></param> 
    /// <param name="outputrow"></param> 
    /// <returns></returns> 
    public override IEnumerable<IRow> Extract(IUnstructuredReader input, IUpdatableRow outputrow)
    {
        char column_delimiter = '\t';
        string line;
        var reader = new StreamReader(input.BaseStream);
        while ((line = reader.ReadLine()) != null)
        {
            var tokens = line.Split(column_delimiter);
            outputrow.Set("Name", tokens[0]);
            outputrow.Set("Company", tokens[1]);
            outputrow.Set("Salary", Convert.ToInt64(tokens[2]));
            yield return outputrow.AsReadOnly();
        }
    }
}

/// <summary> 

/// For more information about writing UDOs, please refer to http://go.microsoft.com/fwlink/?LinkID=623598&clcid=0x409 
/// </summary> 
[SqlUserDefinedExtractor]
public class NBFFSOC : IExtractor
{
    /// <summary> 
    ///  
    /// </summary> 
    /// <param name="input"></param> 
    /// <param name="outputrow"></param> 
    /// <returns></returns> 
    public override IEnumerable<IRow> Extract(IUnstructuredReader input, IUpdatableRow outputrow)
    {
        char column_delimiter = '\t';
        string line;
        var reader = new StreamReader(input.BaseStream);
        while ((line = reader.ReadLine()) != null)
        {
            var tokens = line.Split(column_delimiter);
            outputrow.Set("Name", tokens[0]);
            outputrow.Set("Company", tokens[1]);
            outputrow.Set("Salary", Convert.ToInt64(tokens[2]));
            yield return outputrow.AsReadOnly();
        }
    }
}

/// <summary> 

/// For more information about writing UDOs, please refer to http://go.microsoft.com/fwlink/?LinkID=623598&clcid=0x409 
/// </summary> 
[SqlUserDefinedExtractor]
public class NBFFSOC : IExtractor
{
    /// <summary> 
    ///  
    /// </summary> 
    /// <param name="input"></param> 
    /// <param name="outputrow"></param> 
    /// <returns></returns> 
    public override IEnumerable<IRow> Extract(IUnstructuredReader input, IUpdatableRow outputrow)
    {
        char column_delimiter = '\t';
        string line;
        var reader = new StreamReader(input.BaseStream);
        while ((line = reader.ReadLine()) != null)
        {
            var tokens = line.Split(column_delimiter);
            outputrow.Set("Name", tokens[0]);
            outputrow.Set("Company", tokens[1]);
            outputrow.Set("Salary", Convert.ToInt64(tokens[2]));
            yield return outputrow.AsReadOnly();
        }
    }
}

/// <summary> 

/// For more information about writing UDOs, please refer to http://go.microsoft.com/fwlink/?LinkID=623598&clcid=0x409 
/// </summary> 
[SqlUserDefinedExtractor]
public class NBFFSOC : IExtractor
{
    /// <summary> 
    ///  
    /// </summary> 
    /// <param name="input"></param> 
    /// <param name="outputrow"></param> 
    /// <returns></returns> 
    public override IEnumerable<IRow> Extract(IUnstructuredReader input, IUpdatableRow outputrow)
    {
        char column_delimiter = '\t';
        string line;
        var reader = new StreamReader(input.BaseStream);
        while ((line = reader.ReadLine()) != null)
        {
            var tokens = line.Split(column_delimiter);
            outputrow.Set("Name", tokens[0]);
            outputrow.Set("Company", tokens[1]);
            outputrow.Set("Salary", Convert.ToInt64(tokens[2]));
            yield return outputrow.AsReadOnly();
        }
    }
}

/// <summary> 

/// For more information about writing UDOs, please refer to http://go.microsoft.com/fwlink/?LinkID=623598&clcid=0x409 
/// </summary> 
[SqlUserDefinedExtractor]
public class NBFFSOC : IExtractor
{
    /// <summary> 
    ///  
    /// </summary> 
    /// <param name="input"></param> 
    /// <param name="outputrow"></param> 
    /// <returns></returns> 
    public override IEnumerable<IRow> Extract(IUnstructuredReader input, IUpdatableRow outputrow)
    {
        char column_delimiter = '\t';
        string line;
        var reader = new StreamReader(input.BaseStream);
        while ((line = reader.ReadLine()) != null)
        {
            var tokens = line.Split(column_delimiter);
            outputrow.Set("Name", tokens[0]);
            outputrow.Set("Company", tokens[1]);
            outputrow.Set("Salary", Convert.ToInt64(tokens[2]));
            yield return outputrow.AsReadOnly();
        }
    }
}

/// <summary> 

/// For more information about writing UDOs, please refer to http://go.microsoft.com/fwlink/?LinkID=623598&clcid=0x409 
/// </summary> 
[SqlUserDefinedExtractor]
public class NBFFSOC : IExtractor
{
    /// <summary> 
    ///  
    /// </summary> 
    /// <param name="input"></param> 
    /// <param name="outputrow"></param> 
    /// <returns></returns> 
    public override IEnumerable<IRow> Extract(IUnstructuredReader input, IUpdatableRow outputrow)
    {
        char column_delimiter = '\t';
        string line;
        var reader = new StreamReader(input.BaseStream);
        while ((line = reader.ReadLine()) != null)
        {
            var tokens = line.Split(column_delimiter);
            outputrow.Set("Name", tokens[0]);
            outputrow.Set("Company", tokens[1]);
            outputrow.Set("Salary", Convert.ToInt64(tokens[2]));
            yield return outputrow.AsReadOnly();
        }
    }
}

/// <summary> 

/// For more information about writing UDOs, please refer to http://go.microsoft.com/fwlink/?LinkID=623598&clcid=0x409 
/// </summary> 
[SqlUserDefinedExtractor]
public class NBFFSOC : IExtractor
{
    /// <summary> 
    ///  
    /// </summary> 
    /// <param name="input"></param> 
    /// <param name="outputrow"></param> 
    /// <returns></returns> 
    public override IEnumerable<IRow> Extract(IUnstructuredReader input, IUpdatableRow outputrow)
    {
        char column_delimiter = '\t';
        string line;
        var reader = new StreamReader(input.BaseStream);
        while ((line = reader.ReadLine()) != null)
        {
            var tokens = line.Split(column_delimiter);
            outputrow.Set("Name", tokens[0]);
            outputrow.Set("Company", tokens[1]);
            outputrow.Set("Salary", Convert.ToInt64(tokens[2]));
            yield return outputrow.AsReadOnly();
        }
    }
}

/// <summary> 

/// For more information about writing UDOs, please refer to http://go.microsoft.com/fwlink/?LinkID=623598&clcid=0x409 
/// </summary> 
[SqlUserDefinedExtractor]
public class NBFFSOC : IExtractor
{
    /// <summary> 
    ///  
    /// </summary> 
    /// <param name="input"></param> 
    /// <param name="outputrow"></param> 
    /// <returns></returns> 
    public override IEnumerable<IRow> Extract(IUnstructuredReader input, IUpdatableRow outputrow)
    {
        char column_delimiter = '\t';
        string line;
        var reader = new StreamReader(input.BaseStream);
        while ((line = reader.ReadLine()) != null)
        {
            var tokens = line.Split(column_delimiter);
            outputrow.Set("Name", tokens[0]);
            outputrow.Set("Company", tokens[1]);
            outputrow.Set("Salary", Convert.ToInt64(tokens[2]));
            yield return outputrow.AsReadOnly();
        }
    }
}

/// <summary> 

/// For more information about writing UDOs, please refer to http://go.microsoft.com/fwlink/?LinkID=623598&clcid=0x409 
/// </summary> 
[SqlUserDefinedExtractor]
public class NBFFSOC : IExtractor
{
    /// <summary> 
    ///  
    /// </summary> 
    /// <param name="input"></param> 
    /// <param name="outputrow"></param> 
    /// <returns></returns> 
    public override IEnumerable<IRow> Extract(IUnstructuredReader input, IUpdatableRow outputrow)
    {
        char column_delimiter = '\t';
        string line;
        var reader = new StreamReader(input.BaseStream);
        while ((line = reader.ReadLine()) != null)
        {
            var tokens = line.Split(column_delimiter);
            outputrow.Set("Name", tokens[0]);
            outputrow.Set("Company", tokens[1]);
            outputrow.Set("Salary", Convert.ToInt64(tokens[2]));
            yield return outputrow.AsReadOnly();
        }
    }
}

/// <summary> 

/// For more information about writing UDOs, please refer to http://go.microsoft.com/fwlink/?LinkID=623598&clcid=0x409 
/// </summary> 
[SqlUserDefinedExtractor]
public class NBFFSOC : IExtractor
{
    /// <summary> 
    ///  
    /// </summary> 
    /// <param name="input"></param> 
    /// <param name="outputrow"></param> 
    /// <returns></returns> 
    public override IEnumerable<IRow> Extract(IUnstructuredReader input, IUpdatableRow outputrow)
    {
        char column_delimiter = '\t';
        string line;
        var reader = new StreamReader(input.BaseStream);
        while ((line = reader.ReadLine()) != null)
        {
            var tokens = line.Split(column_delimiter);
            outputrow.Set("Name", tokens[0]);
            outputrow.Set("Company", tokens[1]);
            outputrow.Set("Salary", Convert.ToInt64(tokens[2]));
            yield return outputrow.AsReadOnly();
        }
    }
}

/// <summary> 

/// For more information about writing UDOs, please refer to http://go.microsoft.com/fwlink/?LinkID=623598&clcid=0x409 
/// </summary> 
[SqlUserDefinedExtractor]
public class NBFFSOC : IExtractor
{
    /// <summary> 
    ///  
    /// </summary> 
    /// <param name="input"></param> 
    /// <param name="outputrow"></param> 
    /// <returns></returns> 
    public override IEnumerable<IRow> Extract(IUnstructuredReader input, IUpdatableRow outputrow)
    {
        char column_delimiter = '\t';
        string line;
        var reader = new StreamReader(input.BaseStream);
        while ((line = reader.ReadLine()) != null)
        {
            var tokens = line.Split(column_delimiter);
            outputrow.Set("Name", tokens[0]);
            outputrow.Set("Company", tokens[1]);
            outputrow.Set("Salary", Convert.ToInt64(tokens[2]));
            yield return outputrow.AsReadOnly();
        }
    }
}

/// <summary> 

/// For more information about writing UDOs, please refer to http://go.microsoft.com/fwlink/?LinkID=623598&clcid=0x409 
/// </summary> 
[SqlUserDefinedExtractor]
public class NBFFSOC : IExtractor
{
    /// <summary> 
    ///  
    /// </summary> 
    /// <param name="input"></param> 
    /// <param name="outputrow"></param> 
    /// <returns></returns> 
    public override IEnumerable<IRow> Extract(IUnstructuredReader input, IUpdatableRow outputrow)
    {
        char column_delimiter = '\t';
        string line;
        var reader = new StreamReader(input.BaseStream);
        while ((line = reader.ReadLine()) != null)
        {
            var tokens = line.Split(column_delimiter);
            outputrow.Set("Name", tokens[0]);
            outputrow.Set("Company", tokens[1]);
            outputrow.Set("Salary", Convert.ToInt64(tokens[2]));
            yield return outputrow.AsReadOnly();
        }
    }
}