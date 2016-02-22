using TypeLite;

namespace Nest.TypescriptGenerator
{
	public class ExposedTsGenerator : TsGenerator
	{
		public TypeConvertorCollection Converters => base._typeConvertors;
	}
}