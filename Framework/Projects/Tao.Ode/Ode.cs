#region License
/*
MIT License
Copyright �2003-2005 Tao Framework Team
http://www.taoframework.com
All rights reserved.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion License

using System;
using System.Runtime.InteropServices;
using System.Security;

using real = System.Single;

namespace Tao.Ode {
    #region Class Documentation
    /// <summary>
    ///     ODE (Open Dynamics Engine) binding for .NET.
    /// </summary>
    #endregion Class Documentation
    public sealed class Ode {
        // --- Fields ---
        #region Private Constants
        #region CallingConvention CALLING_CONVENTION
        /// <summary>
        ///     Specifies the calling convention.
        /// </summary>
        /// <remarks>
        ///     Specifies <see cref="CallingConvention.Winapi" />.
        /// </remarks>
        private const CallingConvention CALLING_CONVENTION = CallingConvention.Winapi;
        #endregion CallingConvention CALLING_CONVENTION
        #endregion Private Constants

        #region Public Constants
        #endregion Public Constants

        // --- Constructors & Destructors ---
        #region Ode()
        /// <summary>
        ///     Prevents instantiation.
        /// </summary>
        private Ode() {
        }
        #endregion Ode()



/*
typedef dReal dVector3[4];
typedef dReal dVector4[4];
typedef dReal dMatrix3[4*3];
typedef dReal dMatrix4[4*4];
typedef dReal dMatrix6[8*6];
typedef dReal dQuaternion[4];
*/


        // --- Public Structs ---
		/// <summary>
		/// 
		/// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct dMass {
			/// <summary>
			/// 
			/// </summary>
            public real mass;
			/// <summary>
			/// 
			/// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
            public real[] c;
			/// <summary>
			/// 
			/// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst=12)]
            public real[] I;
        }

        // --- Public Externs ---
        // dWorldID dWorldCreate();
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
        [DllImport("ode.dll", CallingConvention=CALLING_CONVENTION, ExactSpelling=true), SuppressUnmanagedCodeSecurity]
        public static extern IntPtr dWorldCreate();

        // dSpaceID dHashSpaceCreate(dSpaceID space);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="space"></param>
		/// <returns></returns>
        [DllImport("ode.dll", CallingConvention=CALLING_CONVENTION, ExactSpelling=true), SuppressUnmanagedCodeSecurity]
        public static extern IntPtr dHashSpaceCreate(IntPtr space);

        // dJointGroupID dJointGroupCreate(int max_size);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="max_size"></param>
		/// <returns></returns>
        [DllImport("ode.dll", CallingConvention=CALLING_CONVENTION, ExactSpelling=true), SuppressUnmanagedCodeSecurity]
        public static extern IntPtr dJointGroupCreate(int max_size);

        // void dWorldSetGravity(dWorldID, dReal x, dReal y, dReal z);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="world"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
        [DllImport("ode.dll", CallingConvention=CALLING_CONVENTION, ExactSpelling=true), SuppressUnmanagedCodeSecurity]
        public static extern void dWorldSetGravity(IntPtr world, real x, real y, real z);

        // dGeomID dCreatePlane(dSpaceID space, dReal a, dReal b, dReal c, dReal d);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="space"></param>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		/// <param name="d"></param>
		/// <returns></returns>
        [DllImport("ode.dll", CallingConvention=CALLING_CONVENTION, ExactSpelling=true), SuppressUnmanagedCodeSecurity]
        public static extern IntPtr dCreatePlane(IntPtr space, real a, real b, real c, real d);

        // dSpaceID dSimpleSpaceCreate(dSpaceID space);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="space"></param>
		/// <returns></returns>
        [DllImport("ode.dll", CallingConvention=CALLING_CONVENTION, ExactSpelling=true), SuppressUnmanagedCodeSecurity]
        public static extern IntPtr dSimpleSpaceCreate(IntPtr space);

        // void dSpaceAdd(dSpaceID, dGeomID);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="space"></param>
		/// <param name="geom"></param>
        [DllImport("ode.dll", CallingConvention=CALLING_CONVENTION, ExactSpelling=true), SuppressUnmanagedCodeSecurity]
        public static extern void dSpaceAdd(IntPtr space, IntPtr geom);

        // dBodyID dBodyCreate(dWorldID);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="world"></param>
		/// <returns></returns>
        [DllImport("ode.dll", CallingConvention=CALLING_CONVENTION, ExactSpelling=true), SuppressUnmanagedCodeSecurity]
        public static extern IntPtr dBodyCreate(IntPtr world);

        // void dMassSetSphere(dMass *, dReal density, dReal radius);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="mass"></param>
		/// <param name="density"></param>
		/// <param name="radius"></param>
        [DllImport("ode.dll", CallingConvention=CALLING_CONVENTION, ExactSpelling=true), SuppressUnmanagedCodeSecurity]
        public static extern void dMassSetSphere(ref dMass mass, real density, real radius);

        // void dBodySetMass(dBodyID, const dMass *mass);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="body"></param>
		/// <param name="mass"></param>
        [DllImport("ode.dll", CallingConvention=CALLING_CONVENTION, ExactSpelling=true), SuppressUnmanagedCodeSecurity]
        public static extern void dBodySetMass(IntPtr body, ref dMass mass);

        // void dBodySetPosition(dBodyID, dReal x, dReal y, dReal z);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="body"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
        [DllImport("ode.dll", CallingConvention=CALLING_CONVENTION, ExactSpelling=true), SuppressUnmanagedCodeSecurity]
        public static extern void dBodySetPosition(IntPtr body, real x, real y, real z);

        // void dBodyAddForce(dBodyID, dReal fx, dReal fy, dReal fz);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="body"></param>
		/// <param name="fx"></param>
		/// <param name="fy"></param>
		/// <param name="fz"></param>
        [DllImport("ode.dll", CallingConvention=CALLING_CONVENTION, ExactSpelling=true), SuppressUnmanagedCodeSecurity]
        public static extern void dBodyAddForce(IntPtr body, real fx, real fy, real fz);

        // const dReal * dBodyGetPosition(dBodyID);
        [DllImport("ode.dll", CallingConvention=CALLING_CONVENTION, EntryPoint="dBodyGetPosition"), CLSCompliant(false), SuppressUnmanagedCodeSecurity]
        private static extern IntPtr __dBodyGetPosition(IntPtr body);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="body"></param>
		/// <returns></returns>
        public static real[] dBodyGetPosition(IntPtr body) {
            real[] positionArray = new real[3];

            unsafe {
                IntPtr position = __dBodyGetPosition(body);
                real* positionPointer = (real*) position.ToPointer();

                for(int i = 0; i < positionArray.Length; i++) {
                    positionArray[i] = positionPointer[i];
                }
            }

            return positionArray;
        }

        // const dReal * dBodyGetLinearVel(dBodyID);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="body"></param>
		/// <returns></returns>
        [DllImport("ode.dll", CallingConvention=CALLING_CONVENTION, EntryPoint="dBodyGetLinearVel"), CLSCompliant(false), SuppressUnmanagedCodeSecurity]
        private static extern IntPtr __dBodyGetLinearVel(IntPtr body);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="body"></param>
		/// <returns></returns>
        public static real[] dBodyGetLinearVel(IntPtr body) {
            real[] velocityArray = new real[3];

            unsafe {
                IntPtr velocity = __dBodyGetLinearVel(body);
                real* velocityPointer = (real*) velocity.ToPointer();

                for(int i = 0; i < velocityArray.Length; i++) {
                    velocityArray[i] = velocityPointer[i];
                }
            }

            return velocityArray;
        }

        // void dWorldStep (dWorldID, dReal stepsize);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="world"></param>
		/// <param name="stepsize"></param>
        [DllImport("ode.dll", CallingConvention=CALLING_CONVENTION, ExactSpelling=true), SuppressUnmanagedCodeSecurity]
        public static extern void dWorldStep(IntPtr world, real stepsize);

        // void dWorldSetCFM (dWorldID, dReal cfm);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="world"></param>
		/// <param name="crm"></param>
        [DllImport("ode.dll", CallingConvention=CALLING_CONVENTION, ExactSpelling=true), SuppressUnmanagedCodeSecurity]
        public static extern void dWorldSetCFM(IntPtr world, real crm);

        // dGeomID dCreateBox (dSpaceID space, dReal lx, dReal ly, dReal lz);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="space"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		/// <returns></returns>
        [DllImport("ode.dll", CallingConvention=CALLING_CONVENTION, ExactSpelling=true), SuppressUnmanagedCodeSecurity]
        public static extern IntPtr dCreateBox(IntPtr space, real x, real y, real z);

        // void dGeomSetBody (dGeomID, dBodyID);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="geom"></param>
		/// <param name="body"></param>
        [DllImport("ode.dll", CallingConvention=CALLING_CONVENTION, ExactSpelling=true), SuppressUnmanagedCodeSecurity]
        public static extern void dGeomSetBody(IntPtr geom, IntPtr body);

        // void dJointGroupEmpty (dJointGroupID);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="jointGroup"></param>
        [DllImport("ode.dll", CallingConvention=CALLING_CONVENTION, ExactSpelling=true), SuppressUnmanagedCodeSecurity]
        public static extern void dJointGroupEmpty(IntPtr jointGroup);
    }
}