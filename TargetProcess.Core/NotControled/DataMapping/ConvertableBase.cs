namespace TargetProcess.Core.DataMapping
{
    public abstract class ConvertableBase
    {
        private TypeMap _maps;
        public TypeMap TypeMap => _maps ?? (_maps = MappingUtility.GenerateMap(this));
    }
}