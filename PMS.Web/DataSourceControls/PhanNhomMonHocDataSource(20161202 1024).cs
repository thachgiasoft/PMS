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
	/// Represents the DataRepository.PhanNhomMonHocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(PhanNhomMonHocDataSourceDesigner))]
	public class PhanNhomMonHocDataSource : ProviderDataSource<PhanNhomMonHoc, PhanNhomMonHocKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhanNhomMonHocDataSource class.
		/// </summary>
		public PhanNhomMonHocDataSource() : base(new PhanNhomMonHocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the PhanNhomMonHocDataSourceView used by the PhanNhomMonHocDataSource.
		/// </summary>
		protected PhanNhomMonHocDataSourceView PhanNhomMonHocView
		{
			get { return ( View as PhanNhomMonHocDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the PhanNhomMonHocDataSource control invokes to retrieve data.
		/// </summary>
		public PhanNhomMonHocSelectMethod SelectMethod
		{
			get
			{
				PhanNhomMonHocSelectMethod selectMethod = PhanNhomMonHocSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (PhanNhomMonHocSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the PhanNhomMonHocDataSourceView class that is to be
		/// used by the PhanNhomMonHocDataSource.
		/// </summary>
		/// <returns>An instance of the PhanNhomMonHocDataSourceView class.</returns>
		protected override BaseDataSourceView<PhanNhomMonHoc, PhanNhomMonHocKey> GetNewDataSourceView()
		{
			return new PhanNhomMonHocDataSourceView(this, DefaultViewName);
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
	/// Supports the PhanNhomMonHocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class PhanNhomMonHocDataSourceView : ProviderDataSourceView<PhanNhomMonHoc, PhanNhomMonHocKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhanNhomMonHocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the PhanNhomMonHocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public PhanNhomMonHocDataSourceView(PhanNhomMonHocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal PhanNhomMonHocDataSource PhanNhomMonHocOwner
		{
			get { return Owner as PhanNhomMonHocDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal PhanNhomMonHocSelectMethod SelectMethod
		{
			get { return PhanNhomMonHocOwner.SelectMethod; }
			set { PhanNhomMonHocOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal PhanNhomMonHocService PhanNhomMonHocProvider
		{
			get { return Provider as PhanNhomMonHocService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<PhanNhomMonHoc> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<PhanNhomMonHoc> results = null;
			PhanNhomMonHoc item;
			count = 0;
			
			System.Int32 _id;
			System.Int32 _maNhomMonHoc;
			System.String sp2791_NamHoc;
			System.String sp2791_HocKy;
			System.String sp2792_NamHoc;
			System.String sp2792_HocKy;
			System.String sp2792_MaMonHoc;

			switch ( SelectMethod )
			{
				case PhanNhomMonHocSelectMethod.Get:
					PhanNhomMonHocKey entityKey  = new PhanNhomMonHocKey();
					entityKey.Load(values);
					item = PhanNhomMonHocProvider.Get(entityKey);
					results = new TList<PhanNhomMonHoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case PhanNhomMonHocSelectMethod.GetAll:
                    results = PhanNhomMonHocProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case PhanNhomMonHocSelectMethod.GetPaged:
					results = PhanNhomMonHocProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case PhanNhomMonHocSelectMethod.Find:
					if ( FilterParameters != null )
						results = PhanNhomMonHocProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = PhanNhomMonHocProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case PhanNhomMonHocSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = PhanNhomMonHocProvider.GetById(_id);
					results = new TList<PhanNhomMonHoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case PhanNhomMonHocSelectMethod.GetByMaNhomMonHoc:
					_maNhomMonHoc = ( values["MaNhomMonHoc"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaNhomMonHoc"], typeof(System.Int32)) : (int)0;
					results = PhanNhomMonHocProvider.GetByMaNhomMonHoc(_maNhomMonHoc, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				// Custom
				case PhanNhomMonHocSelectMethod.GetByNamHocHocKy:
					sp2791_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2791_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = PhanNhomMonHocProvider.GetByNamHocHocKy(sp2791_NamHoc, sp2791_HocKy, StartIndex, PageSize);
					break;
				case PhanNhomMonHocSelectMethod.GetByNamHocHocKyMaMonHoc:
					sp2792_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2792_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp2792_MaMonHoc = (System.String) EntityUtil.ChangeType(values["MaMonHoc"], typeof(System.String));
					results = PhanNhomMonHocProvider.GetByNamHocHocKyMaMonHoc(sp2792_NamHoc, sp2792_HocKy, sp2792_MaMonHoc, StartIndex, PageSize);
					break;
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
			if ( SelectMethod == PhanNhomMonHocSelectMethod.Get || SelectMethod == PhanNhomMonHocSelectMethod.GetById )
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
				PhanNhomMonHoc entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					PhanNhomMonHocProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<PhanNhomMonHoc> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			PhanNhomMonHocProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region PhanNhomMonHocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the PhanNhomMonHocDataSource class.
	/// </summary>
	public class PhanNhomMonHocDataSourceDesigner : ProviderDataSourceDesigner<PhanNhomMonHoc, PhanNhomMonHocKey>
	{
		/// <summary>
		/// Initializes a new instance of the PhanNhomMonHocDataSourceDesigner class.
		/// </summary>
		public PhanNhomMonHocDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public PhanNhomMonHocSelectMethod SelectMethod
		{
			get { return ((PhanNhomMonHocDataSource) DataSource).SelectMethod; }
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
				actions.Add(new PhanNhomMonHocDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region PhanNhomMonHocDataSourceActionList

	/// <summary>
	/// Supports the PhanNhomMonHocDataSourceDesigner class.
	/// </summary>
	internal class PhanNhomMonHocDataSourceActionList : DesignerActionList
	{
		private PhanNhomMonHocDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the PhanNhomMonHocDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public PhanNhomMonHocDataSourceActionList(PhanNhomMonHocDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public PhanNhomMonHocSelectMethod SelectMethod
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

	#endregion PhanNhomMonHocDataSourceActionList
	
	#endregion PhanNhomMonHocDataSourceDesigner
	
	#region PhanNhomMonHocSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the PhanNhomMonHocDataSource.SelectMethod property.
	/// </summary>
	public enum PhanNhomMonHocSelectMethod
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
		/// Represents the GetByMaNhomMonHoc method.
		/// </summary>
		GetByMaNhomMonHoc,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy,
		/// <summary>
		/// Represents the GetByNamHocHocKyMaMonHoc method.
		/// </summary>
		GetByNamHocHocKyMaMonHoc
	}
	
	#endregion PhanNhomMonHocSelectMethod

	#region PhanNhomMonHocFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhanNhomMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhanNhomMonHocFilter : SqlFilter<PhanNhomMonHocColumn>
	{
	}
	
	#endregion PhanNhomMonHocFilter

	#region PhanNhomMonHocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhanNhomMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhanNhomMonHocExpressionBuilder : SqlExpressionBuilder<PhanNhomMonHocColumn>
	{
	}
	
	#endregion PhanNhomMonHocExpressionBuilder	

	#region PhanNhomMonHocProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;PhanNhomMonHocChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="PhanNhomMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhanNhomMonHocProperty : ChildEntityProperty<PhanNhomMonHocChildEntityTypes>
	{
	}
	
	#endregion PhanNhomMonHocProperty
}

