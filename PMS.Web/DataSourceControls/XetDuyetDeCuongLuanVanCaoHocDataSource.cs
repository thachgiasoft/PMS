#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using System.Web.UI.Design;

using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.XetDuyetDeCuongLuanVanCaoHocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(XetDuyetDeCuongLuanVanCaoHocDataSourceDesigner))]
	public class XetDuyetDeCuongLuanVanCaoHocDataSource : ProviderDataSource<XetDuyetDeCuongLuanVanCaoHoc, XetDuyetDeCuongLuanVanCaoHocKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the XetDuyetDeCuongLuanVanCaoHocDataSource class.
		/// </summary>
		public XetDuyetDeCuongLuanVanCaoHocDataSource() : base(new XetDuyetDeCuongLuanVanCaoHocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the XetDuyetDeCuongLuanVanCaoHocDataSourceView used by the XetDuyetDeCuongLuanVanCaoHocDataSource.
		/// </summary>
		protected XetDuyetDeCuongLuanVanCaoHocDataSourceView XetDuyetDeCuongLuanVanCaoHocView
		{
			get { return ( View as XetDuyetDeCuongLuanVanCaoHocDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the XetDuyetDeCuongLuanVanCaoHocDataSource control invokes to retrieve data.
		/// </summary>
		public XetDuyetDeCuongLuanVanCaoHocSelectMethod SelectMethod
		{
			get
			{
				XetDuyetDeCuongLuanVanCaoHocSelectMethod selectMethod = XetDuyetDeCuongLuanVanCaoHocSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (XetDuyetDeCuongLuanVanCaoHocSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the XetDuyetDeCuongLuanVanCaoHocDataSourceView class that is to be
		/// used by the XetDuyetDeCuongLuanVanCaoHocDataSource.
		/// </summary>
		/// <returns>An instance of the XetDuyetDeCuongLuanVanCaoHocDataSourceView class.</returns>
		protected override BaseDataSourceView<XetDuyetDeCuongLuanVanCaoHoc, XetDuyetDeCuongLuanVanCaoHocKey> GetNewDataSourceView()
		{
			return new XetDuyetDeCuongLuanVanCaoHocDataSourceView(this, DefaultViewName);
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
	/// Supports the XetDuyetDeCuongLuanVanCaoHocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class XetDuyetDeCuongLuanVanCaoHocDataSourceView : ProviderDataSourceView<XetDuyetDeCuongLuanVanCaoHoc, XetDuyetDeCuongLuanVanCaoHocKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the XetDuyetDeCuongLuanVanCaoHocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the XetDuyetDeCuongLuanVanCaoHocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public XetDuyetDeCuongLuanVanCaoHocDataSourceView(XetDuyetDeCuongLuanVanCaoHocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal XetDuyetDeCuongLuanVanCaoHocDataSource XetDuyetDeCuongLuanVanCaoHocOwner
		{
			get { return Owner as XetDuyetDeCuongLuanVanCaoHocDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal XetDuyetDeCuongLuanVanCaoHocSelectMethod SelectMethod
		{
			get { return XetDuyetDeCuongLuanVanCaoHocOwner.SelectMethod; }
			set { XetDuyetDeCuongLuanVanCaoHocOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal XetDuyetDeCuongLuanVanCaoHocService XetDuyetDeCuongLuanVanCaoHocProvider
		{
			get { return Provider as XetDuyetDeCuongLuanVanCaoHocService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<XetDuyetDeCuongLuanVanCaoHoc> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<XetDuyetDeCuongLuanVanCaoHoc> results = null;
			XetDuyetDeCuongLuanVanCaoHoc item;
			count = 0;
			
			System.Int32 _id;
			System.Int32? _maGiangVien_nullable;

			switch ( SelectMethod )
			{
				case XetDuyetDeCuongLuanVanCaoHocSelectMethod.Get:
					XetDuyetDeCuongLuanVanCaoHocKey entityKey  = new XetDuyetDeCuongLuanVanCaoHocKey();
					entityKey.Load(values);
					item = XetDuyetDeCuongLuanVanCaoHocProvider.Get(entityKey);
					results = new TList<XetDuyetDeCuongLuanVanCaoHoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case XetDuyetDeCuongLuanVanCaoHocSelectMethod.GetAll:
                    results = XetDuyetDeCuongLuanVanCaoHocProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case XetDuyetDeCuongLuanVanCaoHocSelectMethod.GetPaged:
					results = XetDuyetDeCuongLuanVanCaoHocProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case XetDuyetDeCuongLuanVanCaoHocSelectMethod.Find:
					if ( FilterParameters != null )
						results = XetDuyetDeCuongLuanVanCaoHocProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = XetDuyetDeCuongLuanVanCaoHocProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case XetDuyetDeCuongLuanVanCaoHocSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = XetDuyetDeCuongLuanVanCaoHocProvider.GetById(_id);
					results = new TList<XetDuyetDeCuongLuanVanCaoHoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case XetDuyetDeCuongLuanVanCaoHocSelectMethod.GetByMaGiangVien:
					_maGiangVien_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32?));
					results = XetDuyetDeCuongLuanVanCaoHocProvider.GetByMaGiangVien(_maGiangVien_nullable, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				// Custom
				default:
					break;
			}

			if ( results != null && count < 1 )
			{
				count = results.Count;

				if ( !String.IsNullOrEmpty(CustomMethodRecordCountParamName) )
				{
					object objCustomCount = EntityUtil.ChangeType(customOutput[CustomMethodRecordCountParamName], typeof(Int32));
					
					if ( objCustomCount != null )
					{
						count = (int) objCustomCount;
					}
				}
			}
			
			return results;
		}
		
		/// <summary>
		/// Gets the values of any supplied parameters for internal caching.
		/// </summary>
		/// <param name="values">An IDictionary object of name/value pairs.</param>
		protected override void GetSelectParameters(IDictionary values)
		{
			if ( SelectMethod == XetDuyetDeCuongLuanVanCaoHocSelectMethod.Get || SelectMethod == XetDuyetDeCuongLuanVanCaoHocSelectMethod.GetById )
			{
				EntityId = GetEntityKey(values);
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation for the current entity if it has
		/// not already been performed.
		/// </summary>
		internal override void DeepLoad()
		{
			if ( !IsDeepLoaded )
			{
				XetDuyetDeCuongLuanVanCaoHoc entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					XetDuyetDeCuongLuanVanCaoHocProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
					// set loaded flag
					IsDeepLoaded = true;
				}
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation on the specified entity collection.
		/// </summary>
		/// <param name="entityList"></param>
		/// <param name="properties"></param>
		internal override void DeepLoad(TList<XetDuyetDeCuongLuanVanCaoHoc> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			XetDuyetDeCuongLuanVanCaoHocProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region XetDuyetDeCuongLuanVanCaoHocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the XetDuyetDeCuongLuanVanCaoHocDataSource class.
	/// </summary>
	public class XetDuyetDeCuongLuanVanCaoHocDataSourceDesigner : ProviderDataSourceDesigner<XetDuyetDeCuongLuanVanCaoHoc, XetDuyetDeCuongLuanVanCaoHocKey>
	{
		/// <summary>
		/// Initializes a new instance of the XetDuyetDeCuongLuanVanCaoHocDataSourceDesigner class.
		/// </summary>
		public XetDuyetDeCuongLuanVanCaoHocDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public XetDuyetDeCuongLuanVanCaoHocSelectMethod SelectMethod
		{
			get { return ((XetDuyetDeCuongLuanVanCaoHocDataSource) DataSource).SelectMethod; }
			set { SetPropertyValue("SelectMethod", value); }
		}

		/// <summary>Gets the designer action list collection for this designer.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.Design.DesignerActionListCollection"/>
		/// associated with this designer.</returns>
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				DesignerActionListCollection actions = new DesignerActionListCollection();
				actions.Add(new XetDuyetDeCuongLuanVanCaoHocDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region XetDuyetDeCuongLuanVanCaoHocDataSourceActionList

	/// <summary>
	/// Supports the XetDuyetDeCuongLuanVanCaoHocDataSourceDesigner class.
	/// </summary>
	internal class XetDuyetDeCuongLuanVanCaoHocDataSourceActionList : DesignerActionList
	{
		private XetDuyetDeCuongLuanVanCaoHocDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the XetDuyetDeCuongLuanVanCaoHocDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public XetDuyetDeCuongLuanVanCaoHocDataSourceActionList(XetDuyetDeCuongLuanVanCaoHocDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public XetDuyetDeCuongLuanVanCaoHocSelectMethod SelectMethod
		{
			get { return _designer.SelectMethod; }
			set { _designer.SelectMethod = value; }
		}

		/// <summary>
		/// Returns the collection of <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// objects contained in the list.
		/// </summary>
		/// <returns>A <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// array that contains the items in this list.</returns>
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			DesignerActionItemCollection items = new DesignerActionItemCollection();
			items.Add(new DesignerActionPropertyItem("SelectMethod", "Select Method", "Methods"));
			return items;
		}
	}

	#endregion XetDuyetDeCuongLuanVanCaoHocDataSourceActionList
	
	#endregion XetDuyetDeCuongLuanVanCaoHocDataSourceDesigner
	
	#region XetDuyetDeCuongLuanVanCaoHocSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the XetDuyetDeCuongLuanVanCaoHocDataSource.SelectMethod property.
	/// </summary>
	public enum XetDuyetDeCuongLuanVanCaoHocSelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetById method.
		/// </summary>
		GetById,
		/// <summary>
		/// Represents the GetByMaGiangVien method.
		/// </summary>
		GetByMaGiangVien
	}
	
	#endregion XetDuyetDeCuongLuanVanCaoHocSelectMethod

	#region XetDuyetDeCuongLuanVanCaoHocFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="XetDuyetDeCuongLuanVanCaoHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class XetDuyetDeCuongLuanVanCaoHocFilter : SqlFilter<XetDuyetDeCuongLuanVanCaoHocColumn>
	{
	}
	
	#endregion XetDuyetDeCuongLuanVanCaoHocFilter

	#region XetDuyetDeCuongLuanVanCaoHocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="XetDuyetDeCuongLuanVanCaoHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class XetDuyetDeCuongLuanVanCaoHocExpressionBuilder : SqlExpressionBuilder<XetDuyetDeCuongLuanVanCaoHocColumn>
	{
	}
	
	#endregion XetDuyetDeCuongLuanVanCaoHocExpressionBuilder	

	#region XetDuyetDeCuongLuanVanCaoHocProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;XetDuyetDeCuongLuanVanCaoHocChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="XetDuyetDeCuongLuanVanCaoHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class XetDuyetDeCuongLuanVanCaoHocProperty : ChildEntityProperty<XetDuyetDeCuongLuanVanCaoHocChildEntityTypes>
	{
	}
	
	#endregion XetDuyetDeCuongLuanVanCaoHocProperty
}

