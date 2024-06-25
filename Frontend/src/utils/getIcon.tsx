import { Icon as Iconify } from '@iconify/react';

interface iGetIconProps {
  name: string;
  width?: number;
  height?: number;
  color?: string;
}

export const getIcon = ({
  name,
  width = 20,
  height = 20,
  color,
}: iGetIconProps) => (
  <Iconify icon={name} width={width} height={height} color={color} />
);
