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
	/// Represents the DataRepository.QuyDoiHoatDongNgoaiGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(QuyDoiHoatDongNgoaiGiangDayDataSourceDesigner))]
	public class QuyDoiHoatDongNgoaiGiangDayDataSource : ProviderDataSource<QuyDoiHoatDongNgoaiGiangDay, QuyDoiHoatDongNgoaiGiangDayKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyDoiHoatDongNgoaiGiangDayDataSource class.
		/// </summary>
		public QuyDoiHoatDongNgoaiGiangDayDataSource() : base(new QuyDoiHoatDongNgoaiGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the QuyDoiHoatDongNgoaiGiangDayDataSourceView used by the QuyDoiHoatDongNgoaiGiangDayDataSource.
		/// </summary>
		protected QuyDoiHoatDongNgoaiGiangDayDataSourceView QuyDoiHoatDongNgoaiGiangDayView
		{
			get { return ( View as QuyDoiHoatDongNgoaiGiangDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the QuyDoiHoatDongNgoaiGiangDayDataSource control invokes to retrieve data.
		/// </summary>
		public QuyDoiHoatDongNgoaiGiangDaySelectMethod SelectMethod
		{
			get
			{
				QuyDoiHoatDongNgoaiGiangDaySelectMethod selectMethod = QuyDoiHoatDongNgoaiGiangDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (QuyDoiHoatDongNgoaiGiangDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the QuyDoiHoatDongNgoaiGiangDayDataSourceView class that is to be
		/// used by the QuyDoiHoatDongNgoaiGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the QuyDoiHoatDongNgoaiGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<QuyDoiHoatDongNgoaiGiangDay, QuyDoiHoatDongNgoaiGiangDayKey> GetNewDataSourceView()
		{
			return new QuyDoiHoatDongNgoaiGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the QuyDoiHoatDongNgoaiGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class QuyDoiHoatDongNgoaiGiangDayDataSourceView : ProviderDataSourceView<QuyDoiHoatDongNgoaiGiangDay, QuyDoiHoatDongNgoaiGiangDayKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyDoiHoatDongNgoaiGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the QuyDoiHoatDongNgoaiGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public QuyDoiHoatDongNgoaiGiangDayDataSourceView(QuyDoiHoatDongNgoaiGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal QuyDoiHoatDongNgoaiGiangDayDataSource QuyDoiHoatDongNgoaiGiangDayOwner
		{
			get { return Owner as QuyDoiHoatDongNgoaiGiangDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal QuyDoiHoatDongNgoaiGiangDaySelectMethod SelectMethod
		{
			get { return QuyDoiHoatDongNgoaiGiangDayOwner.SelectMethod; }
			set { QuyDoiHoatDongNgoaiGiangDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal QuyDoiHoatDongNgoaiGiangDayService QuyDoiHoatDongNgoaiGiangDayProvider
		{
			get { return Provider as QuyDoiHoatDongNgoaiGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<QuyDoiHoatDongNgoaiGiangDay> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<QuyDoiHoatDongNgoaiGiangDay> results = null;
			QuyDoiHoatDongNgoaiGiangDay item;
			count = 0;
			
			System.Int32 _maQuanLy;
			System.Int32? _maHoatDongNgoaiGiangDay_nullable;

			switch ( SelectMethod )
			{
				case QuyDoiHoatDongNgoaiGiangDaySelectMethod.Get:
					QuyDoiHoatDongNgoaiGiangDayKey entityKey  = new QuyDoiHoatDongNgoaiGiangDayKey();
					entityKey.Load(values);
					item = QuyDoiHoatDongNgoaiGiangDayProvider.Get(entityKey);
					results = new TList<QuyDoiHoatDongNgoaiGiangDay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case QuyDoiHoatDongNgoaiGiangDaySelectMethod.GetAll:
                    results = QuyDoiHoatDongNgoaiGiangDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case QuyDoiHoatDongNgoaiGiangDaySelectMethod.GetPaged:
					results = QuyDoiHoatDongNgoaiGiangDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case QuyDoiHoatDongNgoaiGiangDaySelectMethod.Find:
					if ( FilterParameters != null )
						results = QuyDoiHoatDongNgoaiGiangDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = QuyDoiHoatDongNgoaiGiangDayProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case QuyDoiHoatDongNgoaiGiangDaySelectMethod.GetByMaQuanLy:
					_maQuanLy = ( values["MaQuanLy"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.Int32)) : (int)0;
					item = QuyDoiHoatDongNgoaiGiangDayProvider.GetByMaQuanLy(_maQuanLy);
					results = new TList<QuyDoiHoatDongNgoaiGiangDay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case QuyDoiHoatDongNgoaiGiangDaySelectMethod.GetByMaHoatDongNgoaiGiangDay:
					_maHoatDongNgoaiGiangDay_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaHoatDongNgoaiGiangDay"], typeof(System.Int32?));
					results = QuyDoiHoatDongNgoaiGiangDayProvider.GetByMaHoatDongNgoaiGiangDay(_maHoatDongNgoaiGiangDay_nullable, this.StartIndex, this.PageSize, out count);
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
			if ( SelectMethod == QuyDoiHoatDongNgoaiGiangDaySelectMethod.Get || SelectMethod == QuyDoiHoatDongNgoaiGiangDaySelectMethod.GetByMaQuanLy )
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
				QuyDoiHoatDongNgoaiGiangDay entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					QuyDoiHoatDongNgoaiGiangDayProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<QuyDoiHoatDongNgoaiGiangDay> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			QuyDoiHoatDongNgoaiGiangDayProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region QuyDoiHoatDongNgoaiGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the QuyDoiHoatDongNgoaiGiangDayDataSource class.
	/// </summary>
	public class QuyDoiHoatDongNgoaiGiangDayDataSourceDesigner : ProviderDataSourceDesigner<QuyDoiHoatDongNgoaiGiangDay, QuyDoiHoatDongNgoaiGiangDayKey>
	{
		/// <summary>
		/// Initializes a new instance of the QuyDoiHoatDongNgoaiGiangDayDataSourceDesigner class.
		/// </summary>
		public QuyDoiHoatDongNgoaiGiangDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public QuyDoiHoatDongNgoaiGiangDaySelectMethod SelectMethod
		{
			get { return ((QuyDoiHoatDongNgoaiGiangDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new QuyDoiHoatDongNgoaiGiangDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region QuyDoiHoatDongNgoaiGiangDayDataSourceActionList

	/// <summary>
	/// Supports the QuyDoiHoatDongNgoaiGiangDayDataSourceDesigner class.
	/// </summary>
	internal class QuyDoiHoatDongNgoaiGiangDayDataSourceActionList : DesignerActionList
	{
		private QuyDoiHoatDongNgoaiGiangDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the QuyDoiHoatDongNgoaiGiangDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public QuyDoiHoatDongNgoaiGiangDayDataSourceActionList(QuyDoiHoatDongNgoaiGiangDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public QuyDoiHoatDongNgoaiGiangDaySelectMethod SelectMethod
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

	#endregion QuyDoiHoatDongNgoaiGiangDayDataSourceActionList
	
	#endregion QuyDoiHoatDongNgoaiGiangDayDataSourceDesigner
	
	#region QuyDoiHoatDongNgoaiGiangDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the QuyDoiHoatDongNgoaiGiangDayDataSource.SelectMethod property.
	/// </summary>
	public enum QuyDoiHoatDongNgoaiGiangDaySelectMethod
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
		/// Represents the GetByMaQuanLy method.
		/// </summary>
		GetByMaQuanLy,
		/// <summary>
		/// Represents the GetByMaHoatDongNgoaiGiangDay method.
		/// </summary>
		GetByMaHoatDongNgoaiGiangDay
	}
	
	#endregion QuyDoiHoatDongNgoaiGiangDaySelectMethod

	#region QuyDoiHoatDongNgoaiGiangDayFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyDoiHoatDongNgoaiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyDoiHoatDongNgoaiGiangDayFilter : SqlFilter<QuyDoiHoatDongNgoaiGiangDayColumn>
	{
	}
	
	#endregion QuyDoiHoatDongNgoaiGiangDayFilter

	#region QuyDoiHoatDongNgoaiGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyDoiHoatDongNgoaiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyDoiHoatDongNgoaiGiangDayExpressionBuilder : SqlExpressionBuilder<QuyDoiHoatDongNgoaiGiangDayColumn>
	{
	}
	
	#endregion QuyDoiHoatDongNgoaiGiangDayExpressionBuilder	

	#region QuyDoiHoatDongNgoaiGiangDayProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;QuyDoiHoatDongNgoaiGiangDayChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="QuyDoiHoatDongNgoaiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyDoiHoatDongNgoaiGiangDayProperty : ChildEntityProperty<QuyDoiHoatDongNgoaiGiangDayChildEntityTypes>
	{
	}
	
	#endregion QuyDoiHoatDongNgoaiGiangDayProperty
}

