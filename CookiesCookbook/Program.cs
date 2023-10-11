var setting = new Setting(FileFormat.Json, "recipes");

var cookiesRecipeApp = new CookiesRecipesApp(new RecipesRepository(SettingsRegister.All[setting.FileFormat].StringsRepository), new RecipesConsoleUserInteraction());

cookiesRecipeApp.Run(setting.FileName + SettingsRegister.All[setting.FileFormat].FilePath);
