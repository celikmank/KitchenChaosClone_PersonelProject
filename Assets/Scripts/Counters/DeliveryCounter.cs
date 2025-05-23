using UnityEngine;

public class DeliveryCounter : BaseCounter {
   
   public override void Interact(Player player)
   {
      if (player.HasKitchenObject())
      {
         if (player.GetKitchenObject().TryGetPlate(out PlateKitchenObject plateKitchenObject))
         {
            //only accept plates
            
            DeliveryManager.Instance.DeliverRecipe(plateKitchenObject);
            
            player.GetKitchenObject().DestroySelf();
         }
         
      }
      
   }
}
