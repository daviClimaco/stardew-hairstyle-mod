using StardewModdingAPI;
using StardewModdingAPI.Events;

namespace MeuCabeloMod
{
    public class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            this.Monitor.Log("Meu Cabelo Mod carregado com sucesso!", LogLevel.Info);
            helper.Events.Content.AssetRequested += OnAssetRequested;
        }

        private void OnAssetRequested(object sender, AssetRequestedEventArgs e)
        {
            if (e.NameWithoutLocale.IsEquivalentTo("Data/HairData"))
            {
                e.Edit(asset =>
                {
                    var data = asset.AsDictionary<int, string>().Data;
                    //bald hair example
                    data[9001] = "Characters/Farmer/hairstyles/0/0/false/-1/false";
                });
            }
        }
    }
}
