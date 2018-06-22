tabledef(ActionConfig, dictionary, public)
{
	recordmodifier(partial);
	providermodifier(partial);
	fielddef(ModelId, ModelId, int);
	fielddef(Description, Description, string);
	fielddef(Stand, Stand, string);
	fielddef(Run, Run, string);
};
tabledef(CharacterConfig, dictionary, public)
{
	recordmodifier(partial);
	providermodifier(partial);
	fielddef(Id, Id, int);
	fielddef(Description, Description, string);
	fielddef(Model, Model, string);
	fielddef(Scale, Scale, float);
	fielddef(ActionId, ActionId, int);
	fielddef(ActionPrefix, ActionPrefix, string);
};
tabledef(SceneConfig, dictionary, public)
{
	recordmodifier(partial);
	providermodifier(partial);
	fielddef(Id, Id, int);
	fielddef(Description, Description, string);
	fielddef(Script, Script, string);
	fielddef(Navmesh, Navmesh, string);
};
