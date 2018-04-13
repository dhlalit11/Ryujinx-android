using Ryujinx.Core.Input;
using Ryujinx.Core.OsHle.Ipc;
using System.Collections.Generic;

namespace Ryujinx.Core.OsHle.Services.Hid
{
    class IHidServer : IpcService
    {
        private Dictionary<int, ServiceProcessRequest> m_Commands;

        public override IReadOnlyDictionary<int, ServiceProcessRequest> Commands => m_Commands;

        public IHidServer()
        {
            m_Commands = new Dictionary<int, ServiceProcessRequest>()
            {
                {   0, CreateAppletResource                    },
                {   1, ActivateDebugPad                        },
                {  11, ActivateTouchScreen                     },
                {  21, ActivateMouse                           },
                {  31, ActivateKeyboard                        },
                {  66, StartSixAxisSensor                      },
                { 100, SetSupportedNpadStyleSet                },
                { 101, GetSupportedNpadStyleSet                },
                { 102, SetSupportedNpadIdType                  },
                { 103, ActivateNpad                            },
                { 120, SetNpadJoyHoldType                      },
                { 121, GetNpadJoyHoldType                      },
                { 122, SetNpadJoyAssignmentModeSingleByDefault },
                { 123, SetNpadJoyAssignmentModeSingle          },
                { 124, SetNpadJoyAssignmentModeDual            },
                { 125, MergeSingleJoyAsDualJoy                 },
                { 200, GetVibrationDeviceInfo                  },
                { 203, CreateActiveVibrationDeviceList         },
                { 206, SendVibrationValues                     }
            };
        }

        public long CreateAppletResource(ServiceCtx Context)
        {
            Logging.Warn("Stub Called");

            MakeObject(Context, new IAppletResource(Context.Ns.Os.HidSharedMem));

            return 0;
        }

        public long ActivateDebugPad(ServiceCtx Context)
        {
            Logging.Warn("Stub Called");

            return 0;
        }

        public long ActivateTouchScreen(ServiceCtx Context)
        {
            Logging.Warn("Stub Called");

            long AppletResourceUserId = Context.RequestData.ReadInt64();

            return 0;
        }

        public long ActivateMouse(ServiceCtx Context)
        {
            Logging.Warn("Stub Called");

            long AppletResourceUserId = Context.RequestData.ReadInt64();

            return 0;
        }

        public long ActivateKeyboard(ServiceCtx Context)
        {
            Logging.Warn("Stub Called");

            long AppletResourceUserId = Context.RequestData.ReadInt64();

            return 0;
        }

        public long StartSixAxisSensor(ServiceCtx Context)
        {
            Logging.Warn("Stub Called");

            int Handle = Context.RequestData.ReadInt32();

            long AppletResourceUserId = Context.RequestData.ReadInt64();

            return 0;
        }

        public long GetSupportedNpadStyleSet(ServiceCtx Context)
        {
            Logging.Warn("Stub Called");

            Context.ResponseData.Write(0);

            return 0;
        }

        public long SetSupportedNpadStyleSet(ServiceCtx Context)
        {
            Logging.Warn("Stub Called");

            long Unknown0 = Context.RequestData.ReadInt64();
            long Unknown8 = Context.RequestData.ReadInt64();

            return 0;
        }

        public long SetSupportedNpadIdType(ServiceCtx Context)
        {
            Logging.Warn("Stub Called");

            long Unknown = Context.RequestData.ReadInt64();

            return 0;
        }

        public long ActivateNpad(ServiceCtx Context)
        {
            Logging.Warn("Stub Called");

            long Unknown = Context.RequestData.ReadInt64();

            return 0;
        }

        public long SetNpadJoyHoldType(ServiceCtx Context)
        {
            Logging.Warn("Stub Called");

            long Unknown0 = Context.RequestData.ReadInt64();
            long Unknown8 = Context.RequestData.ReadInt64();

            return 0;
        }

        public long GetNpadJoyHoldType(ServiceCtx Context)
        {
            Logging.Warn("Stub Called");

            Context.ResponseData.Write(0L);

            return 0;
        }

        public long SetNpadJoyAssignmentModeSingleByDefault(ServiceCtx Context)
        {
            Logging.Warn("Stub Called");

            HidControllerId HidControllerId = (HidControllerId)Context.RequestData.ReadInt32();
            long AppletUserResourseId = Context.RequestData.ReadInt64();

            return 0;
        }

        public long SetNpadJoyAssignmentModeSingle(ServiceCtx Context)
        {
            Logging.Warn("Stub Called");

            HidControllerId HidControllerId = (HidControllerId)Context.RequestData.ReadInt32();
            long AppletUserResourseId = Context.RequestData.ReadInt64();
            long NpadJoyDeviceType = Context.RequestData.ReadInt64();

            return 0;
        }

        public long SetNpadJoyAssignmentModeDual(ServiceCtx Context)
        {
            Logging.Warn("Stub Called");

            HidControllerId HidControllerId = (HidControllerId)Context.RequestData.ReadInt32();
            long AppletUserResourseId = Context.RequestData.ReadInt64();

            return 0;
        }

        public long MergeSingleJoyAsDualJoy(ServiceCtx Context)
        {
            Logging.Warn("Stub Called");

            long Unknown0 = Context.RequestData.ReadInt32();
            long Unknown8 = Context.RequestData.ReadInt32();
            long AppletUserResourseId = Context.RequestData.ReadInt64();

            return 0;
        }

        public long GetVibrationDeviceInfo(ServiceCtx Context)
        {
            Logging.Warn("Stub Called");

            int VibrationDeviceHandle = Context.RequestData.ReadInt32();

            Context.ResponseData.Write(0L); //VibrationDeviceInfoForIpc

            return 0;
        }

        public long CreateActiveVibrationDeviceList(ServiceCtx Context)
        {
            Logging.Warn("Stub Called");

            MakeObject(Context, new IActiveApplicationDeviceList());

            return 0;
        }

        public long SendVibrationValues(ServiceCtx Context)
        {
            Logging.Warn("Stub Called");

            return 0;
        }
    }
}