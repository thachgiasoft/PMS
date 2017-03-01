#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.VMonHocTinChiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(VMonHocTinChiDataSourceDesigner))]
	public class VMonHocTinChiDataSource : ReadOnlyDataSource<VMonHocTinChi>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VMonHocTinChiDataSource class.
		/// </summary>
		public VMonHocTinChiDataSource() : base(new VMonHocTinChiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the VMonHocTinChiDataSourceView used by the VMonHocTinChiDataSource.
		/// </summary>
		protected VMonHocTinChiDataSourceView VMonHocTinChiView
		{
			get { return ( View as VMonHocTinChiDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the VMonHocTinChiDataSourceView class that is to be
		/// used by the VMonHocTinChiDataSource.
		/// </summary>
		/// <returns>An instance of the VMonHocTinChiDataSourceView class.</returns>
		protected override BaseDataSourceView<VMonHocTinChi, Object> GetNewDataSourceView()
		{
			return new VMonHocTinChiDataSourceView(this, DefaultViewName);
		}
		
		/// <summary>
        /// Creates a cache hashing key based on the startIndex, pageSize and the SelectMethod being used.
        /// </summary>
        /// <param name="startIndex">The current start row index.</param>
        /// <param name="pageSize">The current page size.</param>
        /// <returns>A string that can be used as a key for caching purposes.</returns>
		protected override string CacheHashKey(int startIndex, int pageSize)
        {
			return String.Format("{0}:{1}:{2}", SelectMethod, startIndex, pageSize);
        }
		
		#endregion Methods
	}
	
	/// <summary>
	/// Supports the VMonHocTinChiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class VMonHocTinChiDataSourceView : ReadOnlyDataSourceView<VMonHocTinChi>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VMonHocTinChiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the VMonHocTinChiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public VMonHocTinChiDataSourceView(VMonHocTinChiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal VMonHocTinChiDataSource VMonHocTinChiOwner
		{
			get { return Owner as VMonHocTinChiDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal VMonHocTinChiService VMonHocTinChiProvider
		{
			get { return Provider as VMonHocTinChiService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region VMonHocTinChiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the VMonHocTinChiDataSource class.
	/// </summary>
	public class VMonHocTinChiDataSourceDesigner : ReadOnlyDataSourceDesigner<VMonHocTinChi>
	{
	}

	#endregion VMonHocTinChiDataSourceDesigner

	#region VMonHocTinChiFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VMonHocTinChi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VMonHocTinChiFilter : SqlFilter<VMonHocTinChiColumn>
	{
	}

	#endregion VMonHocTinChiFilter

	#region VMonHocTinChiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VMonHocTinChi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VMonHocTinChiExpressionBuilder : SqlExpressionBuilder<VMonHocTinChiColumn>
	{
	}
	
	#endregion VMonHocTinChiExpressionBuilder		
}

