﻿using AutoMapper;
using DatingApp.BusinesLogic.BusinessModel;
using DatingApp.BusinesLogic.Services.Interfaces;
using DatingApp.DataAccessLayer.Models;
using DatingApp.DataAccessLayer.Repositories;
using DatingApp.DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.BusinesLogic.Services
{
    public class ChatService : IChatService
    {
        IUnitOfWork _unitOfWork = new UnitOfWork();
        public void SendMessage(string  message, ProfileModel recipientId, ProfileModel senderId)
        {
            var messMod = new ChatModel { TextMessage = message, RecepientId = recipientId.Id, SenderId = senderId.Id };
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ChatModel, DatingApp.DataAccessLayer.Models.Chat>());

            var mapper = new Mapper(config);
            var chatBL = mapper.Map<Chat>(messMod);
            _unitOfWork.Chat.Add(chatBL);
            _unitOfWork.Save();
            
        }        

        public List<MessageModel> GetReceivedMesaages(int recepientId)
        {
            return _unitOfWork.Chat.Get(p => p.RecepientId == recepientId).Select(p => new MessageModel
            {
                Id = p.Id,
                SenderName = p.Sender.FirstName,
                RecipientName = p.Recepient.FirstName,
                TextMessage = p.TextMessage
            }).ToList();
        }

        public List<MessageModel> GetSendedMesaages(int senderId)
        {
            return _unitOfWork.Chat.Get(p => p.SenderId == senderId).Select(p => new MessageModel
            {
                Id = p.Id,
                SenderName = p.Sender.FirstName,
                RecipientName = p.Recepient.FirstName,
                TextMessage = p.TextMessage
            }).ToList();
        }
        
    }
}
