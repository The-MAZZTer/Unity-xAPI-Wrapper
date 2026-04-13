This folder contains the contents of https://github.com/dmitry-bym/JsonKnownTypes/tree/6dcc30a29bcfc193f6d5390a8dbc9c7c81bd3b99/src/JsonKnownTypes

I had to make a couple minor bug fixes since it does not work properly with xAPI as-is.

One fix enables the use of a type discriminator of an empty string by changing DiscriminatorValues.cs line 76. It turned out I did not need to make this change.

In JsonKnownTypeConverter I also restricted the known types to only apply if the property type is an exact match for the type we are discriminating. This fixes top level statements being deserialized as object since they don't have an objectType (this is technically a bug in the Unity xAPI Wrapper since statements and substatements, which have objectType, are differentiated in the spec IIRC).

All this is allowed under the MIT license.

Proper fix would be to modify Unity xAPI Wrapper to use System.Text.Json which properly supports type discrimination in deserialization unlike NewtonsoftJson, which only supports it in a specific field.

Some of the xAPI data model classes also need to be reworked to properly reflect the xAPI spec. Statement should not have an ObjectType and should not inherit from Object. A SubStatement class should replace this functionality. Or something, not sure. Actor also should be split into Agent and Group classes with their own ObjectTypes.
