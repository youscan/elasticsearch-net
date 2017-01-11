﻿namespace Nest500
{
	internal static class PropertyNameExtensions
	{
		internal static bool IsConditionless(this PropertyName property)
		{
			return property == null || (property.Name.IsNullOrEmpty() && property.Expression == null && property.Property == null);
		}
	}
}
