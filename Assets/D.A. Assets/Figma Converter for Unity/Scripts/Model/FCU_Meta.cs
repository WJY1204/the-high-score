﻿using UnityEngine;
using System.Collections.Generic;
using System;
using DA_Assets.FCU.Extensions;

namespace DA_Assets.FCU.Model
{
    [Serializable]
    public class FCU_Meta : MonoBehaviour
    {
        [SerializeField] string id;
        [SerializeField] string fixedName;
        [SerializeField] List<FCU_Tag> tags = new List<FCU_Tag>();
        [SerializeField] FCU_Meta rootFrame;
        [SerializeField] FigmaConverterUnity fcuInstance;
        [SerializeField] bool isDownloadable;
        [SerializeField] FCU_Meta text;
        [SerializeField] ButtonComponent buttonComponent;
        [SerializeField] string figmaAligment;
        public void SetData(FObject fobject, FigmaConverterUnity fcuInstance)
        {
            this.id = fobject.GetMetaId(fcuInstance);
            this.fixedName = fobject.FixedName;
            this.tags = fobject.Tags;
            this.fcuInstance = fcuInstance;
            this.isDownloadable = fcuInstance.ProjectParser.IsDownloadable(fobject);
        }

        public string Id { get => id; set => id = value; }
        public string FixedName { get => fixedName; set => fixedName = value; }
        public List<FCU_Tag> Tags { get => tags; set => tags = value; }
        public FCU_Meta RootFrame { get => rootFrame; set => rootFrame = value; }
        public FigmaConverterUnity FigmaConverterUnity { get => fcuInstance; set => fcuInstance = value; }
        public FCU_Meta Text { get => text; set => text = value; }
        public bool IsDownloadable { get => isDownloadable; set => isDownloadable = value; }
        public ButtonComponent ButtonComponent { get => buttonComponent; set => buttonComponent = value; }
        public string FigmaAligment { get => figmaAligment; set => figmaAligment = value; }
    }
}