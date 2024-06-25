import styled from 'styled-components';

export const Container = styled.div`
  grid-area: AS;
  background-color: ${(prop) => prop.theme.colors.darker};
  color: ${(prop) => prop.theme.colors.white};
  width: 100%;
  height: 100%;
  padding: 5px;
`;

export const BoxContent = styled.div`
  background-color: ${(prop) => prop.theme.colors.light};
  width: 100%;
  height: 100%;
  padding: 10px;
`;
