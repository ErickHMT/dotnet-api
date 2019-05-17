using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApi.Domain.Services.Communication {
    public class SaveResponse<T> : BaseResponse {

        public T _object { get; private set; }

        private SaveResponse(bool success, string message, T data) : base(success, message) {
            _object = data;
        }

        private SaveResponse(bool success, string message) : base(success, message) { }

        public SaveResponse(T data) : this(true, string.Empty, data) { }

        public SaveResponse(string message) : this(false, message) { }

    }
}
