using Assets.Scripts.GameLogic;
using System;
using UnityEngine;

namespace behaviac
{
	internal class Assignment_bt_WrapperAI_Soldier_BTSoldierSiege_node38 : Assignment
	{
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			uint objID = (uint)pAgent.GetVariable(1128863647u);
			Vector3 actorPosition = ((ObjAgent)pAgent).GetActorPosition(objID);
			pAgent.SetVariable<Vector3>("p_TargetPos", actorPosition, 1602776625u);
			return result;
		}
	}
}
