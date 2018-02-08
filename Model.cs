namespace Cbs.Datameer.Metadata.Model
{
    public interface IVariableRepository
    {
        string Put(Variable variable);
        Variable Get(string id);
    }


    public class Variable
    {
        
    }


}