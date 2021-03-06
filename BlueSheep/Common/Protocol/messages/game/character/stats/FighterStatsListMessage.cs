









// Generated on 12/11/2014 19:01:24
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.Protocol.Types;
using BlueSheep.Common.IO;
using BlueSheep.Engine.Types;

namespace BlueSheep.Common.Protocol.Messages
{
    public class FighterStatsListMessage : Message
    {
        public new const uint ID =6322;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public Types.CharacterCharacteristicsInformations stats;
        
        public FighterStatsListMessage()
        {
        }
        
        public FighterStatsListMessage(Types.CharacterCharacteristicsInformations stats)
        {
            this.stats = stats;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            stats.Serialize(writer);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            stats = new Types.CharacterCharacteristicsInformations();
            stats.Deserialize(reader);
        }
        
    }
    
}